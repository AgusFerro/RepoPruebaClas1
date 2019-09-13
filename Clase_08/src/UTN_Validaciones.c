/*
 * UTN_Validaciones.c
 *
 *  Created on: 12 sep. 2019
 *      Author: alumno
 */
#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include <string.h>
#include "UTN_Validaciones.h"

int validarInt(char *pArray,int limite)//,int minimo,int maximo)
{
	int retorno = -1;
	int i;
	if(pArray != NULL && limite > 0)
	{
		for(i=0;i<limite;i++)
		{
			if(pArray[i]>='0'/*minimo*/ && pArray[i]<='9'/*maximo*/)
			{
				retorno = 0;
			}
			else
			{
				retorno = -1;
				break;
			}
		}

	}
	return retorno;
}

int utn_esNumerica(char input[])
{
	int length = strlen(input);
	int i,retorno;

	retorno = 0;
	for(i=0;i<length;i++)
	{
		if(input[i] < '0' || input[i] > '9')
		{
			if(input[i]=='-' && i==0)
			// valida que se encuentre ese caracter en la primera posicion
			{
				continue;
			}
			if(input[i]=='+' && i==0)
			{
				continue;
			}
			retorno = -1;
			break;
		}
	}
	return retorno;
}
