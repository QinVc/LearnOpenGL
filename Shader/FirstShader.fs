#version 330 core
in vec4 vertexColor; // 从顶点着色器传来的输入变量（名称相同、类型相同）
in vec2 OurtexCoord;

out vec4 color; // 片段着色器输出的变量名可以任意命名，类型必须是vec4
uniform sampler2D ourTexture;

void main()
{
    color = texture(ourTexture, OurtexCoord);
}