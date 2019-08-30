#include <stdio.h>
#include <stdlib.h>

int getNumero(int *pNumero,int max,int min, int Reintentos);

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
		printf("ERROR");
	}
}

int getNumero(int *pNumero,int max,int min, int fReintentos)
{
	int numeroAux = *pNumero;

		printf("\nIngrese un numero ");
		scanf("%d",&numeroAux);
		while(!(numeroAux <= max && numeroAux >= min) && fReintentos > 0)
		{
			fReintentos--;

			printf("\nReingrese numero, cantidad de reintentos: %d ",fReintentos);

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
