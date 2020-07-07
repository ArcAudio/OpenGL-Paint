#version 330 core
out vec4 FragColor;

in vec2 TexCoords;
uniform int swidth;
uniform int sheight;

uniform sampler2D screenTexture;

void main()
{
    vec2 iResolution = vec2(swidth,sheight);
    vec2 p = gl_FragCoord.xy/iResolution.xy;
    vec4 col = texture(screenTexture, TexCoords,1.0);
    vec4 rcol = vec4(1.0f,0.0f,0.0f,0.0f);
    FragColor = col+rcol;
}
