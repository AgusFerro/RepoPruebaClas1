#include <stdio.h>
#include <stdlib.h>

int getNumero(int *pNumero,int max,int min, int Reintentos);

#define MSG_NUM "Ingrese numero "
#define MSG_RNUM "Reingrese numero, cantidad de reintentos: "
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
