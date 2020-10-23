#version v

uniform float RadiusPixels;
uniform vec2 RectSize;

in vec2 UV; 
in vec4 vertColor; 
out vec4 fragColor;

float sdBox(in vec2 p, in vec2 b)
{
    vec2 d = abs(p)-b;
    return length(max(d,vec2(0))) + min(max(d.x,d.y),0.0);
}

float sdCircle(vec2 p, float r)
{
  return length(p) - r;
}

float opUnion(float d1, float d2) { return min(d1,d2); }

void main() {
    float aspect = RectSize.x / RectSize.y;
    vec2 ratio = vec2(aspect, 1.0); // The actual resolution here.
    vec2 uv = ((2 * UV) - 1.) * ratio;

    float mn = min(ratio.x, ratio.y) / 2;
    float radiusInRatio = min((RadiusPixels / RectSize.x) * ratio.x, mn);
    vec2 deflatedRect = ratio - vec2(radiusInRatio); // The rectangle without the radius.
    vec2 left = vec2(deflatedRect.x, deflatedRect.y);

    // Four rounded corners
    float d = sdCircle(uv + left, radiusInRatio);
    d = opUnion(d, sdCircle(uv - left, radiusInRatio));
    d = opUnion(d, sdCircle(uv + vec2(left.x, -left.y), radiusInRatio));
    d = opUnion(d, sdCircle(uv + vec2(-left.x, left.y), radiusInRatio));

    // Fill
    d = opUnion(d, sdBox(uv, vec2(deflatedRect.x + radiusInRatio, left.y)));
    d = opUnion(d, sdBox(uv, vec2(left.x, deflatedRect.y + radiusInRatio)));

    fragColor = mix(vertColor, vec4(0.0), smoothstep(0.0, 0.10, sign(d)));
    if (fragColor.a < 0.01)discard;
}