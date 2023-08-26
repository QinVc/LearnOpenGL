#version 330 core
out vec4 color;

in vec3 FragPos;  
in vec3 Normal;  
in vec2 TexCoord;

//点光
// struct Light
// {
//     vec3 position;
//     vec3 ambient;
//     vec3 diffuse;
//     vec3 specular;
// };

//平行光
// struct Light
// {
//     vec3 direction;
//     vec3 ambient;
//     vec3 diffuse;
//     vec3 specular;
// };

//聚光灯
struct Light
{
    vec3 position;
    vec3 spotdirection;
    float Cutoff;
    float outterCutoff;
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
};

struct Material
{
    sampler2D diffuse;
    sampler2D specular;
    float shininess;
};

uniform Material material;
uniform Light light;
// uniform vec3 lightPos; 
uniform vec3 viewPos;


void main()
{
    vec3 result=vec3(0,0,0);
    // Ambient
    vec3 ambient = light.ambient * vec3(texture(material.diffuse, TexCoord));
  	
    // Diffuse 
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(light.position - FragPos);
    //for Direction Light
    // vec3 lightDir=normalize(-light.direction);
    float theta= dot(-lightDir,normalize(light.spotdirection));
    float diff = max(dot(norm, lightDir), 0.0);
    vec3 diffuse =  light.diffuse * vec3(texture(material.diffuse,TexCoord)) * diff;
    // Specular
    vec3 viewDir = normalize(viewPos - FragPos);
    vec3 reflectDir = reflect(-lightDir, norm);  
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
    vec3 specular = light.specular * spec * vec3(texture(material.specular,TexCoord));

    float epsilon=light.Cutoff-light.outterCutoff;
    float Intensity = clamp((theta-light.outterCutoff)/epsilon,0,1);

    result = ambient + diffuse*Intensity + specular*Intensity;
    color = vec4(result, 1.0f);
} 