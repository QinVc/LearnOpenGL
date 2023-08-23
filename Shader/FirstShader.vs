#version 330 core
layout (location = 0) in vec3 position;
layout (location = 1) in vec2 texCoord;

out vec2 TexCoord;
out vec4 OurColor;

uniform mat4 model;
uniform mat4 view;
uniform mat4 proj;

void main()
{
    gl_Position = proj * view * model  * vec4(position, 1.0f);
    TexCoord = texCoord;
    OurColor=vec4(0.5,0.5,0,1);
}