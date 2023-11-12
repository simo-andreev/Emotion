#version v 

#ifdef SKINNED_SHADOW_MAP
#define SHADOW_MAP 1
#define SKINNED 1
#endif

uniform mat4 projectionMatrix; 
uniform mat4 viewMatrix; 
uniform mat4 modelMatrix; 
 
// Shader toy API uniforms. 
uniform float iTime; // shader playback time (in seconds) 
uniform vec3 iResolution; // viewport resolution (in pixels) 
 
layout(location = 0)in vec3 vertPos; 
layout(location = 1)in vec2 uv; 
layout(location = 2)in vec4 color;

layout(location = 3)in vec3 normal; 

#ifdef SKINNED
layout(location = 4)in vec4 boneIds;
layout(location = 5)in vec4 boneWeights;
#endif

uniform vec4 sunColor;
uniform vec3 sunDirection;

uniform mat4 lightViewProj;

#ifdef SKINNED
const int MAX_BONES = 126;
const int MAX_BONE_INFLUENCE = 4;
uniform mat4 boneMatrices[MAX_BONES];
#endif

// Goes to the frag shader.  
out vec2 UV; 
out vec4 vertColor;

out vec3 fragNormal;
out vec3 fragLightDir;

out vec3 fragPosition;

void main() { 
    // Pass to frag.
    UV = uv;
    vertColor = color;

    
    fragLightDir = normalize(sunDirection);

    vec4 totalPosition = vec4(vertPos, 1.0);

#ifdef SKINNED
    mat4 totalTransform = boneMatrices[int(boneIds[0])] * boneWeights[0];
    for (int i = 1; i < MAX_BONE_INFLUENCE; i++)
    {
        totalTransform += boneMatrices[int(boneIds[i])] * boneWeights[i];
    }
    totalPosition = totalTransform * totalPosition;
	fragNormal = normalize(mat3(transpose(inverse(modelMatrix * totalTransform))) * normal);
#else
	fragNormal = normalize(mat3(transpose(inverse(modelMatrix))) * normal);
#endif

	fragPosition = vec3(modelMatrix * totalPosition);

    // Multiply by projection.
    #ifdef SHADOW_MAP
        gl_Position = lightViewProj * modelMatrix * totalPosition;
    #else
        gl_Position = projectionMatrix * viewMatrix * modelMatrix * totalPosition;
    #endif
}