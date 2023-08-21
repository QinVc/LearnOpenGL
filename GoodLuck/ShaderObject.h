#pragma once
#ifndef SHADER_H
#define SHADER_H

#include <string>
#include <fstream>
#include <sstream>
#include <iostream>

#include <glew.h> // 包含glew来获取所有的必须OpenGL头文件
#include <glfw3.h>

class ShaderObject
{
public:
	// 程序ID
	GLuint Program;
	// 构造器读取并构建着色器
	ShaderObject(const GLchar* vertexPath, const GLchar* fragmentPath);
	// 使用程序
	void Use();
};

#endif