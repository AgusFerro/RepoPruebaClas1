/*
 * UTN_Inputs.c
 *
 *  Created on: 11 sep. 2019
 *      Author: alumno
 */

#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include <string.h>
#include "UTN_Inputs.h"
#include "UTN_Validaciones.h"

int getInt(	int *pResultado,
			char *pMensaje,
			char *pMensajeError,
			int minimo,
			int maximo,
			int reintentos)
{
	int retorno = -1;
	int buffer;
	char input[50];
	int length;
	do
	{
		printf("%s",pMensaje);
		fgets(input,sizeof(input),stdin);
		length = strlen(input);
		length--;
		if(validarInt(input,length)==0)
		{
			buffer = atoi(input);
			if(buffer >= minimo && buffer <= maximo)
			{
				*pResultado = buffer;
				retorno = 0;
				break;
			}
			else
			{
				printf("%s",pMensajeError);
				reintentos--;
			}

		}
		else
		{
			printf("No es un numero");
			reintentos--;
		};
		/*buffer = atoi(numero);
		if(buffer >= minimo && buffer <= maximo)
		{
			*pResultado = buffer;
			retorno = 0;
			break;
		}
		printf("%s",pMensajeError);
		reintentos--;*/
	}while(reintentos >= 0);
	return retorno;
}

void getString(char mensaje[],char input[])
{
    printf("%s",mensaje);
    //scanf("%s",input);

    // fgets es una funcion que ya existe!!!
    fgets(input,sizeof(*input),stdin);
}

