/*
 * utn.c
 *
 *  Created on: 29 ago. 2019
 *      Author: alumno
 */
#include <stdio.h>
#include "utn.h"



int getNumero(int *pNumero,int max,int min, int fReintentos)
{
	int numeroAux = *pNumero;

		printf("%s",MSG_NUM);
		scanf("%d",&numeroAux);
		while(!(numeroAux <= max && numeroAux >= min) && fReintentos > 0)
		{
			fReintentos--;

			printf("%s ""%d",MSG_RNUM,fReintentos);

			__fpurge(stdin);

			scanf("%d",&numeroAux);
		}

		if(fReintentos == 0)
		{
			return -1;
		}
		else
		{
			*pNumero = numeroAux;
			return 0;
		}

}
