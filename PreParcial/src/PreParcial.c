#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include "Inputs.h"
#include "Pantalla.h"
#include "Publicidad.h"

int main(void)
{
	abmFantasma();
	return 0;
}

int abmFantasma(void)
{
	int opcion;
	int reintentos = 3;
	int ID = 0, flag1 = 0, flag2 = 0;
	Pantalla listaPantalla[CANT_EMP];
	Publicidad listaPublicidad[CANT_EMP];
	pantalla_Inicializar(listaPantalla,CANT_EMP);
	publicidad_Inicializar(listaPublicidad,CANT_EMP);
	imprimeMenu();
	do
	{
		__fpurge(stdin);
		scanf("%d",&opcion);
		switch(opcion)
		{
			case 1:
				pantalla_alta(listaPantalla,CANT_EMP,&ID);
				flag1++;
				imprimeMenu();
				break;

			case 2:
				if(flag1<1)
				{
					printf("\nNo hay datos cargados");
					imprimeMenu();
				}
				else
				{
					pantalla_modificar(listaPantalla, CANT_EMP);
					imprimeMenu();
				}
				break;

			case 3:
				if(flag1<1)
				{
					printf("\nNo hay datos cargados");
					printf("\nBaja correcta");
					imprimeMenu();
				}
				else
				{
					pantalla_baja(listaPantalla,listaPublicidad,CANT_EMP,CANT_EMP);
					flag1--;
					imprimeMenu();
				}
				break;

			case 4:
				if(flag1<1)
				{
					printf("\nNo hay datos cargados");
					imprimeMenu();
				}
				else
				{
					pantalla_listar(listaPantalla,CANT_EMP);
					publicidad_alta(listaPublicidad,CANT_EMP,ID);
					flag2++;
					imprimeMenu();
				}
				break;

			case 5:
				if(flag1<1 || flag2<1)
				{
					printf("\nNo hay datos cargados");
					imprimeMenu();
				}
				else
				{
					publicidad_modificar(listaPublicidad,CANT_EMP,ID);
					imprimeMenu();
				}
				break;

			case 6:
				if(flag1<1 || flag2<1)
				{
					printf("\nNo hay datos cargados");
					imprimeMenu();
				}
				else
				{
					publicidad_baja(listaPublicidad,CANT_EMP,ID);
					imprimeMenu();
				}
				break;

			case 7:
				break;

			case 8:
				publicidad_listar(listaPublicidad,CANT_EMP);
				imprimeMenu();
				break;

			case 9:
				pantalla_listar(listaPantalla,CANT_EMP);
				imprimeMenu();
				break;

			case 10:
				break;

			case 11:
				printf("Hasta pronto!");
				break;
			default:
				reintentos--;
				printf("Opcion incorrecta, cantidad de reintentos: %d \n",reintentos);
				imprimeMenu();
				break;
			}

		}while(opcion != 11 && reintentos > 1);
		if(reintentos <= 1)
		{
			printf("Cantidad de reintentos agotada\n");
		}
			return 0;
}
