﻿#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int  a, b, c, d;
	
	scanf("%d", &a);
	scanf("%d", &b);
	
	for (int i = 0; i < b; i++)
	{
		scanf("%d %d", &c, &d);
		a -= c * d;
	}
	if (a==0)
	{
		printf("Yes");
	}
	else
	{
		printf("No");
	}

}