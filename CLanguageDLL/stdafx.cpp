#include "stdafx.h"

extern "C" __declspec(dllexport) int __stdcall Add(int m, int n)
{
	return m + n;
}
C_int Subtract(int m, int n)
{
	return m - n;
}
C_int Multiply(int m, int n)
{
	return m * n;
}
C_int Divide(int m, int n)
{
	return m / n;
}
