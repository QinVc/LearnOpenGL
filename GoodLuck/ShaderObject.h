#pragma once
#ifndef SHADER_H
#define SHADER_H

#include <string>
#include <fstream>
#include <sstream>
#include <iostream>

#include <glew.h> // ����glew����ȡ���еı���OpenGLͷ�ļ�
#include <glfw3.h>

class ShaderObject
{
public:
	// ����ID
	GLuint Program;
	// ��������ȡ��������ɫ��
	ShaderObject(const GLchar* vertexPath, const GLchar* fragmentPath);
	// ʹ�ó���
	void Use();
};

#endif