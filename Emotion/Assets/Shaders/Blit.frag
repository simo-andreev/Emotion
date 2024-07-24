#version v
 
uniform LOWP sampler2D mainTexture;
 
// Comes in from the vertex shader. 
in LOWP vec2 UV; 
in LOWP vec4 vertColor;
 
out LOWP vec4 fragColor; 
 
#using "Shaders/getTextureColor.c"

void main() { 
    fragColor = getTextureColor(mainTexture, UV) * vertColor;
}