#version v

uniform vec3 iResolution; // viewport resolution (in pixels)

uniform vec3 cameraPosition; // world pos
uniform mat4 viewMatrix;

// Shadow
#define CASCADE_RESOLUTION vec2(1024.0)
#define CASCADE_COUNT 4

#define VSM 1

#ifdef VSM
#define CascadeSamplerType sampler2D
#else
#define CascadeSamplerType sampler2DShadow
#endif

// todo: array texture
uniform CascadeSamplerType shadowMapTextureC1;
uniform CascadeSamplerType shadowMapTextureC2;
uniform CascadeSamplerType shadowMapTextureC3;
uniform CascadeSamplerType shadowMapTextureC4;

uniform int renderingShadowMap;
uniform float cascadeUnitToTexel[CASCADE_COUNT];
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
    int cascade = CASCADE_COUNT - 1;
    
    for (int i = 0; i < CASCADE_COUNT; i++)
    {
        vec4 fragPosLightSpace = cascadeLightProj[i] * vec4(fragPosition, 1.0);
        if (abs(fragPosLightSpace.x) <= 0.99 &&
            abs(fragPosLightSpace.y) <= 0.99 &&
            abs(fragPosLightSpace.z) <= 0.99)
        {
            cascade = i;
            break;
        }
    }

    return cascade;
}

float linstep(float low, float high, float v)
{
    return clamp((v-low)/(high-low), 0.0, 1.0);
}

#ifdef VSM
float SampleShadowMap(vec3 uvAndDepth, int cascade)
{
    vec4 outCol = vec4(1.0);
    if (cascade == 0)
        outCol = texture(shadowMapTextureC1, uvAndDepth.xy);
    else if (cascade == 1)
        outCol = texture(shadowMapTextureC2, uvAndDepth.xy);
    else if (cascade == 2)
        outCol = texture(shadowMapTextureC3, uvAndDepth.xy);
    else if (cascade == 3)
        outCol = texture(shadowMapTextureC4, uvAndDepth.xy);

    // Basic shadow mapping V
    // return 1.0 - step(uvAndDepth.z - 0.0005, outCol.r);

    // VSM
    vec2 moments = outCol.rg;
    float p = step(uvAndDepth.z, moments.r);
    float variance = max(moments.g - moments.r * moments.r, 0.00002);

    float d = uvAndDepth.z - moments.r;
    float pMax = variance / (variance + d*d);
    pMax = linstep(0.4, 1.0, pMax);

    return 1.0 - min(max(p, pMax), 1.0);
}
#else
float SampleShadowMap(vec3 uvAndDepth, int cascade)
{
    float outCol = 0.0;
    if (cascade == 0)
        outCol = texture(shadowMapTextureC1, uvAndDepth);
    else if (cascade == 1)
        outCol = texture(shadowMapTextureC2, uvAndDepth);
    else if (cascade == 2)
        outCol = texture(shadowMapTextureC3, uvAndDepth);
    else if (cascade == 3)
        outCol = texture(shadowMapTextureC4, uvAndDepth);
    return outCol;
}
#endif

float SampleShadowMap_Witness(vec2 baseUv, vec2 uvOffset, vec2 shadowMapSizeInv, int cascade, float depth)
{
    vec2 uv = baseUv + uvOffset * shadowMapSizeInv;
    vec3 uvAndDepth = vec3(uv, depth);
    return SampleShadowMap(uvAndDepth, cascade);
}

float TheWitness_GetShadowAmount(int cascadeIdx, vec3 shadowPos)
{
    float cascadeSizes[CASCADE_COUNT] = float[CASCADE_COUNT](2048.0, 1024.0, 512.0, 256.0);
    vec2 shadowMapSize = vec2(cascadeSizes[cascadeIdx]);
    float numSlices = CASCADE_COUNT;

    vec2 uv = shadowPos.xy * shadowMapSize; // 1 unit - 1 texel
    vec2 shadowMapSizeInv = 1.0 / shadowMapSize; // texel size

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

    float lightDepth = shadowPos.z - 0.0005;
    sum += uw0 * vw0 * SampleShadowMap_Witness(base_uv, vec2(u0, v0), shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw1 * vw0 * SampleShadowMap_Witness(base_uv, vec2(u1, v0), shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw0 * vw1 * SampleShadowMap_Witness(base_uv, vec2(u0, v1), shadowMapSizeInv, cascadeIdx, lightDepth);
    sum += uw1 * vw1 * SampleShadowMap_Witness(base_uv, vec2(u1, v1), shadowMapSizeInv, cascadeIdx, lightDepth);

    return sum * 1.0f / 16.0;
}

float GetShadowAmount()
{
    // Determine which cascade this fragment is in
    int cascadeIdx = GetCurrentShadowCascade();

    // Get the fragment position in light space.
    vec4 fragPosLightSpace = cascadeLightProj[cascadeIdx] * vec4(fragPosition, 1.0);
    vec3 projCoords = fragPosLightSpace.xyz / fragPosLightSpace.w;
    projCoords = projCoords * 0.5 + 0.5;

    //return SampleShadowMap(projCoords, cascadeIdx);
    return TheWitness_GetShadowAmount(cascadeIdx, projCoords);
}

void main()
{
    if (renderingShadowMap != -1)
    {
#ifdef VSM
        float depth = gl_FragCoord.z;
        float dx = dFdx(depth);
        float dy = dFdy(depth);
        float moment2 = depth * depth + 0.25 * (dx * dx + dy * dy);
        fragColor = vec4(depth, moment2, 0.0, 1.0);
#else
        fragColor = vec4(1.0);
#endif
        return;
    }

    // Calculate the color of the object.
    vec4 objectColor = getTextureColor(diffuseTexture, UV) * diffuseColor * vertColor;
    objectColor = ApplyColorTint(objectColor, objectTint);

    // Cascade debug
    //int cascade = GetCurrentShadowCascade();
    //objectColor = GetCascadeDebugColor(cascade);

    // Normal debug
    // objectColor = vec4(fragNormal.x, fragNormal.y, fragNormal.z, 1.0);

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