#include <stdio.h>
#include <stdlib.h>
#include "utn.h"


#define MSG_ERR "ERROR"

int main(void)
{	int maximo = 99;
	int minimo = 1;
	int reintentos = 3;
	int numero;


	if(getNumero(&numero,maximo,minimo,reintentos) == 0)
	{
		printf("\nEl numero es: %d",numero);
	}
	else
	{
		printf("%s",MSG_ERR);
	}
}


