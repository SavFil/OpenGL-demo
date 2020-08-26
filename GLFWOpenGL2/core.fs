#version 330 core
out vec4 FragColor;  
in vec3 ourColor;
in vec2 ourTex;

uniform sampler2D ourTexture1;
uniform sampler2D ourTexture2;
uniform float offset;
  
void main()
{
    FragColor = mix(texture( ourTexture1, ourTex), texture( ourTexture2, -ourTex), offset);//texture( ourTexture1, ourTex) * vec4(ourColor, 1.0);
}