/*
 ============================================================================
 Name        : Clase_05.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include "Clase-05.h"

int main(void)
{
	int edades[QTY_EDADES] = {100,200,300,400,500};
	int mayor,menor,suma=0,promedio;

	obtenerMayorArrayInt(edades,QTY_EDADES,&mayor);
	obtenerMenorArrayInt(edades,QTY_EDADES,&menor);
	obtenerSumaYPromedioArrayInt(edades,QTY_EDADES,&suma,&promedio);

	printf("%d\n",mayor);
	printf("%d\n",menor);
	printf("%d\n",suma);
	printf("%d\n",promedio);
	return EXIT_SUCCESS;
}






