
#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;
uniform float iTime;
uniform int swidth;
uniform int sheight;
uniform float mouseX;
uniform float mouseY;
vec2 iChannelResolution = vec2(800,600);

#define fragColor FragColor
#define S 5. // Scale
void main()
{

    vec2 iResolution = vec2(swidth,sheight);

    vec2 fragCoord = vec2(gl_FragCoord.xy);
    vec2 uv = fragCoord/iResolution.xy;
    vec2 iMouse = vec2(mouseX,1-mouseY+sheight);

    fragColor = texture(texture1,fragCoord/iResolution.xy);
    if (length(iMouse.xy-fragCoord) < 10.) fragColor = vec4(1.);

}
