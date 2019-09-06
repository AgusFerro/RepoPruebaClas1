
#include <stdio.h>
#include <stdlib.h>
#include "Clase-06.h"
#define largo 6

int main(void)
{
	int arrayInt[largo] = {1,5,67,42,3,8};
	int i,j,aux;

	for(i = 0;i < largo-1;i++)
	{
		for(j = i+1;j < largo;j++)
		{
			if(arrayInt[i] > arrayInt[j])
			{
				aux = arrayInt[i];
				arrayInt[i] = arrayInt[j];
				arrayInt[j] = aux;

			}
		}
	}


	return 0;
}
