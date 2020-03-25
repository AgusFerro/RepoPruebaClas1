#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "UTN_Inputs.h"


//Inicializa
int initArrayInt(int *pArray , int limite, int valor)
{
	int retorno = -1;
	int i;
	if(pArray != NULL && limite > 0)
	{
		for(i=0;i<limite;i++)
		{
			pArray[i]=valor;
		}
		retorno = 0;
	}
	return retorno;
}
//Imprime
int printArrayInt(int *pArray , int limite)
{
	int retorno = -1;
	int i;
	printf("\nDEBUG\n");
	if(pArray != NULL && limite > 0)
	{
		for(i=0;i<limite;i++)
		{
			printf("\n\t%i",pArray[i]);
		}
		retorno = 0;
	}
	return retorno;
}
//Carga
int getArrayInt(int *pArray,int limite,char *pMensaje,char *pMensajeError,int minimo,int maximo,int reintentos)
{
	int retorno = -1;
	int buffer;
	int i=0;
	char respuesta;
	printf("\nDEBUG\n");
	if(pArray != NULL && limite > 0)
	{
		do
		{

			if(	getInt(	&buffer, pMensaje, pMensajeError, minimo, maximo, reintentos) == 0)
			{
				pArray[i] = buffer;
				i++;
				if(i == limite)
				{
					break;
				}
			}

			printf("Continuar (s/n)? \n");
			fflush(stdin); // __fpurge(stdin)
			scanf("%c",&respuesta);
		}while(respuesta != 'n');
		retorno = i;
	}
	return retorno;
}
//Minimo y Maximo
int minMaxArrayInt(int* pArray,int limite,int* minimo,int* maximo)
{
    int min=*minimo;
    int max=*maximo;
    int i;

    for (i=0; i<limite; i++)
    {
        if(i==0){
            min=pArray[i];
            max=pArray[i];
        }
        else
        {
            if (pArray[i]<min){
                min=pArray[i];
            }
            if (pArray[i]>max){
                max=pArray[i];
            }
        }
    }
    *minimo = min;
    *maximo = max;

   return 0;
}

//Suma
int sumaArrayInt(int* pArray,int limite,int* resultado)
{
    int res=0;
    int i;

    for (i=0; i<limite; i++)
    {
        res=res+pArray[i] ;
    }

    *resultado = res;

   return 0;
}

//Promedio
int promedioArrayInt(int* pArray,int limite,int* resultadoProm)
{
    int res=0;
    int i;

    for (i=0; i<limite; i++)
    {
        res=res+pArray[i] ;
    }

    *resultadoProm = res/limite;

   return 0;
}
//Ordena
int OrdenaArrayInt(int* pArray,int limite)
{
    int i, aux, flagOrdenado=-1;
    int* arrayAux = pArray;


    while(flagOrdenado==-1)
    {
        flagOrdenado=0;
        //1PASADA
        for(i=0; i<(limite-1);i++)
        {
           if(arrayAux[i]>arrayAux[i+1]){
            //swap
            aux = arrayAux[i];
            arrayAux[i]=arrayAux[i+1];
            arrayAux[i+1]=aux;
            flagOrdenado=-1;
           }
        }

    }

    pArray = arrayAux;

   return 0;
}

int cargarSetDatos(char pArrayNombre[][50], int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite)
{
    int i;
    int buffer;
    char auxNombre[50];
    for (i=0; i<limite; i++)
    {
        fflush(stdin);
        getString("Ingrese Nombre del Alumno ","Error",auxNombre);
        //arrayNombres[i]=arrayNombres;  NOOO
        strcpy(pArrayNombre[i],auxNombre);

        //printf("Ingrese el legajo del alumno: ");
        //scanf("%d", &aLegajo[i]);
        fflush(stdin);
        if(getInt(&buffer, "+Ingrese el legajo del alumno: ", "Error. ", 1, 100, 2) == 0)
        {
                aLegajo[i]=buffer;
        }else
            {
                aLegajo[i]=0;
            }
        printf("Ingrese el sexo del alumno: ");
        fflush(stdin);
        scanf("%c",&aSexo[i]);
        fflush(stdin);
        printf("Ingrese la edad del alumno: ");
        scanf("%d", &aEdad[i]);
        printf("Ingrese la nota 1er Parcial del alumno: ");
        scanf("%d", &aNota1P[i]);
        printf("Ingrese la nota 2do Parcial del alumno: ");
        scanf("%d", &aNota2P[i]);
        aPromedio[i] = (((float)aNota1P[i]+aNota2P[i])/2);
       }
    return 0;
}
int mostrarEstudiante(char pArrayNombre[50], int aLegajo, char aSexo, int aEdad, int aNota1P,int aNota2P, float aPromedio)
{
    printf("\n%s            %d        %c     %d       %d         %d           %.2f",pArrayNombre, aLegajo, aSexo, aEdad, aNota1P, aNota2P, aPromedio);

    return 0;
}
int mostrarEstudiantes(char pArrayNombre[][50],int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite)
{
    int i;
    printf("\nnombre     legajo    sexo   edad   nota1P     nota2P    promedio");
    for (i=0; i<limite; i++)
    {
        mostrarEstudiante(pArrayNombre[i], aLegajo[i], aSexo[i], aEdad[i], aNota1P[i], aNota2P[i], aPromedio[i]);
    }

    return 0;
}
int ordenarLegajoEstudiantes(char pArrayNombre[][50], int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite, int aOrden)
{
    int i;
    int aux;
    char auxS;
    float auxF;
    char auxNom[50];
    int flag=-1;


    while(flag==-1)
    {
        flag=0;
        for (i=0; i<limite-1; i++)
        {
            if(aOrden==1)
            {
                if(aLegajo[i]>aLegajo[i+1])
                {
                    aux= aLegajo[i];
                    aLegajo[i]=aLegajo[i+1];
                    aLegajo[i+1]=aux;

                    auxS= aSexo[i];
                    aSexo[i]=aSexo[i+1];
                    aSexo[i+1]=auxS;

                    aux= aEdad[i];
                    aEdad[i]=aEdad[i+1];
                    aEdad[i+1]=aux;

                    aux= aNota1P[i];
                    aNota1P[i]=aNota1P[i+1];
                    aNota1P[i+1]=aux;

                    aux= aNota2P[i];
                    aNota2P[i]=aNota2P[i+1];
                    aNota2P[i+1]=aux;

                    auxF= aPromedio[i];
                    aPromedio[i]=aPromedio[i+1];
                    aPromedio[i+1]=auxF;

                    strcpy(auxNom, pArrayNombre[i]);
                    strcpy(pArrayNombre[i], pArrayNombre[i+1]);
                    strcpy(pArrayNombre[i+1],auxNom);
                    flag=-1;
                }
            }
            if(aOrden==2)
            {
                 if(aLegajo[i]<aLegajo[i+1])
                {
                    aux= aLegajo[i];
                    aLegajo[i]=aLegajo[i+1];
                    aLegajo[i+1]=aux;

                    auxS= aSexo[i];
                    aSexo[i]=aSexo[i+1];
                    aSexo[i+1]=auxS;

                    aux= aEdad[i];
                    aEdad[i]=aEdad[i+1];
                    aEdad[i+1]=aux;

                    aux= aNota1P[i];
                    aNota1P[i]=aNota1P[i+1];
                    aNota1P[i+1]=aux;

                    aux= aNota2P[i];
                    aNota2P[i]=aNota2P[i+1];
                    aNota2P[i+1]=aux;

                    auxF= aPromedio[i];
                    aPromedio[i]=aPromedio[i+1];
                    aPromedio[i+1]=auxF;

                    strcpy(auxNom, pArrayNombre[i]);
                    strcpy(pArrayNombre[i], pArrayNombre[i+1]);
                    strcpy(pArrayNombre[i+1],auxNom);

                    flag=-1;
                }
            }
        }
    }
    return 0;
}
int ordenarPromedioEstudiantes(char pArrayNombre[][50],int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite)
{
    int i;
    int aux;
    char auxS;
    float auxF;
    char auxNom[50];
    int flag=-1;

    while(flag==-1)
    {
        flag=0;
        for (i=0; i<limite-1; i++)
        {
            if(aPromedio[i]>aPromedio[i+1])
            {
                aux= aLegajo[i];
                aLegajo[i]=aLegajo[i+1];
                aLegajo[i+1]=aux;

                auxS= aSexo[i];
                aSexo[i]=aSexo[i+1];
                aSexo[i+1]=auxS;

                aux= aEdad[i];
                aEdad[i]=aEdad[i+1];
                aEdad[i+1]=aux;

                aux= aNota1P[i];
                aNota1P[i]=aNota1P[i+1];
                aNota1P[i+1]=aux;

                aux= aNota2P[i];
                aNota2P[i]=aNota2P[i+1];
                aNota2P[i+1]=aux;

                auxF= aPromedio[i];
                aPromedio[i]=aPromedio[i+1];
                aPromedio[i+1]=auxF;

                strcpy(auxNom, pArrayNombre[i]);
                strcpy(pArrayNombre[i], pArrayNombre[i+1]);
                strcpy(pArrayNombre[i+1],auxNom);
                flag=-1;
                }
                if(aPromedio[i]==aPromedio[i+1])
                {
                    if(strcmp(pArrayNombre[i],pArrayNombre[i+1])>0)
                    {
                            strcpy(auxNom, pArrayNombre[i]);
                            strcpy(pArrayNombre[i], pArrayNombre[i+1]);
                            strcpy(pArrayNombre[i+1],auxNom);

                            aux= aLegajo[i];
                            aLegajo[i]=aLegajo[i+1];
                            aLegajo[i+1]=aux;

                            auxS= aSexo[i];
                            aSexo[i]=aSexo[i+1];
                            aSexo[i+1]=auxS;

                            aux= aEdad[i];
                            aEdad[i]=aEdad[i+1];
                            aEdad[i+1]=aux;

                            aux= aNota1P[i];
                            aNota1P[i]=aNota1P[i+1];
                            aNota1P[i+1]=aux;

                            aux= aNota2P[i];
                            aNota2P[i]=aNota2P[i+1];
                            aNota2P[i+1]=aux;

                            //auxF= aPromedio[i];
                            //aPromedio[i]=aPromedio[i+1];
                            //aPromedio[i+1]=auxF;
                            flag=-1;
                    }
                }
            }
        }
    return 0;
}
