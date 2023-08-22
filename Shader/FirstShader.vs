#version 330 core
layout (location = 0) in vec3 position;
layout (location = 1) in vec2 texCoord;

out vec2 TexCoord;
out vec4 OurColor;

void main()
{
    gl_Position = vec4(position, 1.0f);
    TexCoord = texCoord;
    OurColor=vec4(0.5,0.5,0,1);
}