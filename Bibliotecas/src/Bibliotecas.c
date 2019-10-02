/*
 ============================================================================
 Name        : Bibliotecas.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "Inputs.h"

int main(void)
{
	char nombre[50];
	char letra;

	//utn_getName("Ingrese Nombre","Error",10,50,3,nombre);
	//printf("%s",nombre);

	utn_getChar("Ingrese de a hasta Z","Error",'a',"Z",3,&letra);

}
