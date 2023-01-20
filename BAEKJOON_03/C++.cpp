#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a,b=0;
	scanf("%d", &a);

	for (int i = 1; i <= a; i++)
	{
		b += i;
	}
	printf("%d", b);
}