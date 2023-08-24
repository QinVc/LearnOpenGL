#version 330 core
layout (location = 0) in vec3 position;

out vec2 TexCoord;
out vec4 OurColor;

uniform mat4 model;
uniform mat4 view;
uniform mat4 proj;

void main()
{
    gl_Position = proj * view * model  * vec4(position, 1.0f);
    // gl_Position=vec4(position,1.0f);
    OurColor=vec4(0.5,0.5,0,1);
}