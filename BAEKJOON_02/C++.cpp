#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int line , a, b;
	scanf("%d", &line);

	for (int i = 0; i < line; i++)
	{
		scanf("%d %d", &a, &b);
		printf("%d\n", a + b);
	}
}