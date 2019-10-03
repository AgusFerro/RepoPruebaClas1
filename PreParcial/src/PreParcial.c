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
	int opcion,opcionListar;
	int reintentos = 3;
	int ID = 0, flag1 = 0;
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
					fantasma_modificar(listaFantasma, CANT_EMP);
					printf("\nBaja correcta");
					imprimeMenu();
				}
				break;

			case 3:
				if(flag1<1)
				{
					printf("\nNo hay datos cargados");
					imprimeMenu();
				}
				else
				{
					fantasma_baja(listaFantasma,CANT_EMP);
					flag1--;
					imprimeMenu();
				}
				break;

			case 4:
				if(flag1<1)
				{
					printf("\nNo hay datos cargados");
				}
				else
				{
					utn_getInt(&opcionListar,"\n1.PromedioSueldos - 2.ListaEmpleados ","\nError",1,2,2);
					switch(opcionListar)
					{
					case 1:
						//promedioEmpleados(listaFantasma,CANT_EMP);
						break;
					case 2:
						//sortEmpleados(listaFantasma, CANT_EMP);
						fantasma_listar(listaFantasma, CANT_EMP);
						break;
					}

				}
				imprimeMenu();
				break;

			case 5:
				printf("Hasta pronto!");
				break;
			default:
				reintentos--;
				printf("Opcion incorrecta, cantidad de reintentos: %d \n",reintentos);
				imprimeMenu();
				break;
			}

		}while(opcion != 5 && reintentos > 1);
		if(reintentos <= 1)
		{
			printf("Cantidad de reintentos agotada\n");
		}
			return 0;
}
