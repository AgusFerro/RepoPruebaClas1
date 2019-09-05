/*
 * Clase-05.c
 *
 *  Created on: 4 sep. 2019
 *      Author: alumno
 */
#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include "Clase-05.h"

int obtenerMayorArrayInt(int *pArray, int limite, int *pMayor)
{
	int i;
	*pMayor = pArray[0];

	for(i=0;i<limite;i++)
	{
		if(pArray[i] > *pMayor)
		{
			*pMayor=pArray[i];
		}
	}
	return 0;
}

int obtenerMenorArrayInt(int *pArray, int limite, int *pMenor)
{
	int i;
	*pMenor = pArray[0];

	for(i=0;i<limite;i++)
	{
		if(pArray[i] < *pMenor)
		{
			*pMenor=pArray[i];
		}
	}
	return 0;
}

int obtenerSumaYPromedioArrayInt(int *pArray, int limite, int *pSuma, int *pPromedio)
{
	int i;

	for(i=0;i<limite;i++)
	{
		*pSuma = *pSuma + pArray[i];
	}

	*pPromedio = *pSuma/limite;
	return 0;
}

//A partir de este punto, termina mi biblioteca

int initArrayInt(int *pArray , int limite, int valor)
{
	int retorno = -1;
	int i;
	if(pArray != NULL && limite > 0)
	{
		for(i=0;i<limite;i++)
		{
			pArray[i]=valor;
		}
		retorno = 0;
	}
	return retorno;
}



int printArrayInt(int *pArray , int limite)
{
	int retorno = -1;
	int i;
	printf("\nDEBUG\n");
	if(pArray != NULL && limite > 0)
	{
		for(i=0;i<limite;i++)
		{
			printf("\n\t%i",pArray[i]);
		}
		retorno = 0;
	}
	return retorno;
}

int getArrayInt(	int *pArray,
					int limite,
					char *pMensaje,
					char *pMensajeError,
					int minimo,
					int maximo,
					int reintentos)
{
	int retorno = -1;
	int buffer;
	int i=0;
	char respuesta;
	printf("\nDEBUG\n");
	if(pArray != NULL && limite > 0)
	{
		do
		{

			if(	getInt(	&buffer,
						pMensaje,
						pMensajeError,
						minimo,
						maximo,
						reintentos) == 0)
			{
				pArray[i] = buffer;
				i++;
				if(i == limite)
				{
					break;
				}
			}

			printf("Continuar (s/n)? \n");
			__fpurge(stdin); // fflush(stdin)
			scanf("%c",&respuesta);
		}while(respuesta != 'n');
		retorno = i;
	}
	return retorno;
}

int getInt(	int *pResultado,
			char *pMensaje,
			char *pMensajeError,
			int minimo,
			int maximo,
			int reintentos)
{
	int retorno = -1;
	int buffer;
	do
	{
		printf("%s",pMensaje);
		__fpurge(stdin);
		if(scanf("%d",&buffer)==1 && buffer >= minimo && buffer <= maximo)
		{
			*pResultado = buffer;
			retorno = 0;
			break;
		}
		printf("%s",pMensajeError);
		reintentos--;
	}while(reintentos >= 0);
	return retorno;
}
