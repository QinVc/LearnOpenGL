#version 330 core
in vec3 OurColor;
in vec3 FragPos;
in vec3 Normal;
out vec4 color;

uniform vec3 lightPos;

void main()
{
    float ambientStrength=0.5f;
    vec3 lightColor=vec3(0.0,1.0,0.0);
    vec3 direction=normalize(lightPos-FragPos);
    vec3 normalVec=normalize(Normal);
    //漫反射光的直射系数
    float diffuse = max(dot(direction,normalVec),0);
    //被物体吸收，最后逃出来的光
    vec3 diffColor=lightColor*diffuse*OurColor;
    vec3 ambientColor=lightColor*ambientStrength*OurColor;
    vec3 res= ambientColor+diffColor;

    color=vec4(res,1.0f);
}