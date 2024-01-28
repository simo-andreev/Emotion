#version v

uniform vec3 iResolution; // viewport resolution (in pixels)

uniform vec3 cameraPosition; // world pos
uniform mat4 viewMatrix;

// Shadow
#define CASCADE_RESOLUTION vec2(2048.0)
#define CASCADE_COUNT 4

// todo: array texture
uniform sampler2DShadow shadowMapTextureC1;
uniform sampler2DShadow shadowMapTextureC2;
uniform sampler2DShadow shadowMapTextureC3;
uniform sampler2DShadow shadowMapTextureC4;

uniform int renderingShadowMap;
uniform float cascadePlaneFarZ[CASCADE_COUNT];
uniform mat4 cascadeLightProj[CASCADE_COUNT];

// LightModel
uniform vec3 sunDirection;
uniform float ambientLightStrength;
uniform float diffuseStrength;
uniform float shadowOpacity;
uniform vec4 ambientColor;

// 0 - default
// 1 - no ambient+diffuse
// 2 - no receive shadow
// 3 - 2 and 3
uniform int lightMode;

// Material
uniform sampler2D diffuseTexture;
uniform vec4 diffuseColor;
uniform vec4 objectTint;

// Comes in from the vertex shader.
in vec3 vertPos;
in vec2 UV; 
in vec4 vertColor;
 
in vec3 fragPosition; // world pos
in vec3 fragNormal; // multiplied by normal matrix
in vec3 fragLightDir;

out vec4 fragColor; 
 
#using "Shaders/getTextureColor.c"
#using "Shaders/ColorHelpers.c"

vec4 GetCascadeDebugColor(int cascade)
{
    if (cascade == 0)
        return vec4(1.0, 0.0, 0.0, 1.0);
    else if (cascade == 1)
        return vec4(0.0, 1.0, 0.0, 1.0);
    else if (cascade == 2)
        return vec4(0.0, 0.0, 1.0, 1.0);
    else if (cascade == 3)
        return vec4(1.0, 1.0, 0.0, 1.0);

    return vec4(0.0);
}

int GetCurrentShadowCascade()
{
    // Determine which cascade this fragment is in
    int cascade = CASCADE_COUNT;
    vec4 fragPosViewSpace = viewMatrix * vec4(fragPosition, 1.0);
    float depthValue = abs(fragPosViewSpace.z);
    
    for (int i = 0; i < CASCADE_COUNT; i++)
    {
        if (depthValue < cascadePlaneFarZ[i])
        {
            cascade = i;
            break;
        }
    }

    return cascade;
}

vec3 GetShadowPosOffset(float nDotL, vec3 normal)
{
    float OffsetScale = 0.0f;
    vec2 shadowMapSize = CASCADE_RESOLUTION;
    float numSlices = CASCADE_COUNT;

    float normalOffsetScale = 0.2000f;
    float texelSize = 2.0f / shadowMapSize.x;
    float nmlOffsetScale = clamp(1.0f - nDotL, 0.0, 1.0);
    return texelSize * normalOffsetScale * nmlOffsetScale * normal;
}

float SampleShadowMap(vec2 baseUv, float u, float v, vec2 shadowMapSizeInv, int cascade, float depth)
{
    vec2 uv = baseUv + vec2(u, v) * shadowMapSizeInv;
    vec3 uvAndDepth = vec3(uv, depth);

    float textureVal = 0.0;
    if (cascade == 0)
    {
        return texture(shadowMapTextureC1, uvAndDepth);
    }
    else if (cascade == 1)
    {
        return texture(shadowMapTextureC2, uvAndDepth);
    }
    else if (cascade == 2)
    {
        return texture(shadowMapTextureC3, uvAndDepth);
    }
    else if (cascade == 3)
    {
        return texture(shadowMapTextureC4, uvAndDepth);
    }
}


float TheWitness_GetShadowAmount(int cascadeIdx, vec3 shadowPos)
{
    vec2 shadowMapSize = CASCADE_RESOLUTION;
    float numSlices = CASCADE_COUNT;

    vec2 uv = shadowPos.xy * shadowMapSize; // 1 unit - 1 texel
    vec2 shadowMapSizeInv = 1.0 / shadowMapSize;

    vec2 base_uv;
    base_uv.x = floor(uv.x + 0.5);
    base_uv.y = floor(uv.y + 0.5);

    float s = (uv.x + 0.5 - base_uv.x);
    float t = (uv.y + 0.5 - base_uv.y);

    base_uv -= vec2(0.5, 0.5);
    base_uv *= shadowMapSizeInv;

    float sum = 0;

    float uw0 = (3 - 2 * s);
    float uw1 = (1 + 2 * s);

    float u0 = (2 - s) / uw0 - 1;
    float u1 = s / uw1 + 1;

    float vw0 = (3 - 2 * t);
    float vw1 = (1 + 2 * t);

    float v0 = (2 - t) / vw0 - 1;
    float v1 = t / vw1 + 1;

    float bias = 0.00050f;
    float lightDepth = shadowPos.z - bias;

    sum += uw0 * vw0 * SampleShadowMap(base_uv, u0, v0, shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw1 * vw0 * SampleShadowMap(base_uv, u1, v0, shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw0 * vw1 * SampleShadowMap(base_uv, u0, v1, shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw1 * vw1 * SampleShadowMap(base_uv, u1, v1, shadowMapSizeInv, cascadeIdx, lightDepth);

    return sum * 1.0f / 16.0;
}

float GetShadowAmount()
{
    // Determine which cascade this fragment is in
    int cascade = GetCurrentShadowCascade();

    // Get the fragment position in light space.
    vec4 fragPosLightSpace = cascadeLightProj[cascade] * vec4(fragPosition, 1.0);
    vec3 projCoords = fragPosLightSpace.xyz / fragPosLightSpace.w;
    projCoords = projCoords * 0.5 + 0.5;

    float currentDepth = projCoords.z;
    if (currentDepth > 1.0)
    {
        if (cascade == CASCADE_COUNT) return 0.0;
        cascade = cascade + 1;

        fragPosLightSpace = cascadeLightProj[cascade] * vec4(fragPosition, 1.0);
        projCoords = fragPosLightSpace.xyz / fragPosLightSpace.w;
        projCoords = projCoords * 0.5 + 0.5;
        currentDepth = projCoords.z;
    }

    float nDotL = clamp(dot(fragNormal, fragLightDir), 0.0, 1.0);
    return TheWitness_GetShadowAmount(cascade, projCoords + GetShadowPosOffset(nDotL, fragNormal));
}

void main()
{
    if (renderingShadowMap != -1)
    {
        fragColor = vec4(1.0);
        return;
    }

    // Calculate the color of the object.
    vec4 objectColor = getTextureColor(diffuseTexture, UV) * diffuseColor * vertColor;
    objectColor = ApplyColorTint(objectColor, objectTint);

    // Cascade/tinting debug
    //fragColor = objectColor;
    //return;

    // Cascade debug
    //int cascade = GetCurrentShadowCascade();
    //objectColor = GetCascadeDebugColor(cascade);

    vec3 finalColor = objectColor.rgb;

    // Diffuse+Ambient Light
    if (lightMode != 1 && lightMode != 3) // Flat shading flags
    {
        // Normal diffuse factor
        //float diffuseFactor = max(dot(fragNormal, fragLightDir), 0.0);

        // Valve Half Lambert diffuse factor
        // https://developer.valvesoftware.com/wiki/Half_Lambert
        float diffuseFactor = dot(fragNormal, fragLightDir) * 0.5 + 0.5;

        // Combine ambient and diffuse
        vec3 ambient = ambientColor.rgb * ambientLightStrength;
        vec3 diffuse = mix(objectColor.rgb, objectColor.rgb * diffuseFactor, diffuseStrength);
        finalColor = diffuse * ambient;
    }

    // Shadow
    if (lightMode != 2 && lightMode != 3) // Dont receive shadow flags
    {
        float shadow = GetShadowAmount() * shadowOpacity;
        finalColor *= 1.0 - shadow;
    }

    fragColor = vec4(finalColor.rgb, objectColor.a);
    if (fragColor.a < 0.01)discard;
}