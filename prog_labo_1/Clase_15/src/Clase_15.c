#include <stdio.h>
#include <stdlib.h>
#include <stdio_ext.h>
#include <string.h>

int main(void) {
	int* punteroInt ; // Declaro un puntero a Int
	int variableInt ; // Declaro una variable del tipo Int

	variableInt = 44; // Asigno un valor a la variable
	punteroInt = &variableInt; // Obtengo la posición de memoria
	printf("Valor: %d", *punteroInt);
	return 0;
}
