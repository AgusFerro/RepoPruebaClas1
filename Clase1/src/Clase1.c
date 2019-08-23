/*
 ============================================================================
 Name        : Clase1.c
 Author      : Agustin
 Version     :
 Copyright   : GLP 3
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int pideSuma(int* resultado);

int main(void)
{
	int resultado;

	if(pideSuma(&resultado) == 0)
	{
		printf("\nEl valor es: %d",resultado);
	}
	else
	{
		printf("ERROR");
	}
	return 0;
}

int pideSuma(int* resultado)
{
	int num1;
	int num2;

	printf("\nIngresa un numero ");
	scanf("%d",&num1);
	printf("\nIngresa un numero ");
	scanf("%d",&num2);
	*resultado = num1 + num2;
	return 0;
}
