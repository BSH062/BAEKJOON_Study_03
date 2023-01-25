#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int line,a,b;
	scanf("%d", &line);
	//동적할당
	int* rel = new int[line];
		
	for (int i = 0; i < line; i++)
	{
		scanf("%d %d", &a, &b);
		rel[i] = a + b;
	}
	for (int i = 0; i < line; i++)
	{
		printf("%d\n", rel[i]);
	}

}