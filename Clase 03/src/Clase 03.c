/*
 ============================================================================
 Name        : Clase.c
 Author      : Agustin
 Version     :
 Copyright   : GLP 3
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int calculoMaxYMin(int *pFlag,int numeroFun,int *pMax, int *pMin);

int main(void)
{
	int numero;
	char respuesta;
	int Max = 0;
	int Min = 0;
	int flag = 0;

	do
	{
		printf("\nIngrese un numero");
		scanf("%d",&numero);
		calculoMaxYMin(&flag,numero,&Max,&Min);
		printf("\nDesea continuar? s/n");
		__fpurge(stdin);
		scanf("%c",&respuesta);

	} while(respuesta != 'n');

	printf("El Maximo es %d ",Max);
	printf("El Minimo es %d ",Min);


}

int calculoMaxYMin(int *pFlag,int numeroFun,int *pMax,int *pMin)
{
	int Maximo = *pMax;
	int Minimo = *pMin;
	int flag = *pFlag;

	if(flag == 0)
	{
		Maximo = numeroFun;
		Minimo = numeroFun;
		*pFlag = 1;
		printf("Entro");
	}

	if(numeroFun > Maximo)
	{
		Maximo = numeroFun;
		printf("Max");
	}

	if(numeroFun < Minimo)
	{
		Minimo = numeroFun;
		printf("Min");
	}

	*pMax = Maximo;
	*pMin = Minimo;

	return 0;
}
