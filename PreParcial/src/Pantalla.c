
#include <string.h>
#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include "Inputs.h"
#include "Pantalla.h"
#include "Publicidad.h"

void imprimeMenu()
{
	printf("\n1.Alta");
	printf("\n2.Baja");
	printf("\n3.Modificacion");
	printf("\n4.Informar");
	printf("\n5.Salir");
	printf("\n");

}

void imprimeMenuModif()
{
	printf("\na.Nombre");
	printf("\nb.Apellido");
	printf("\nc.Sueldo");
	printf("\nd.Sector");
	printf("\ns.Salir");
	printf("\n");

}

int pantalla_Inicializar(Pantalla array[], int size)
{
    int retorno=-1;
    if(array!= NULL && size>0)
    {
        for(;size>0;size--)
        {
            array[size-1].isEmpty=1;
        }
        retorno=0;
    }
    return retorno;
}

//*****************************************

int pantalla_buscarEmpty(Pantalla array[], int size, int* posicion)
{
    int retorno=-1;
    int i;
    if(array!= NULL && size>=0 && posicion!=NULL)
    {
        for(i=0;i<size;i++)
        {
            if(array[i].isEmpty==1)
            {
                retorno=0;
                *posicion=i;
                break;
            }
        }
    }
    return retorno;
}


int pantalla_buscarID(Pantalla array[], int size, int valorBuscado, int* posicion)
{
    int retorno=-1;
    int i;
    if(array!= NULL && size>=0)
    {
        for(i=0;i<size;i++)
        {
            if(array[i].isEmpty==1)
                continue;
            else if(array[i].idPantalla==valorBuscado)
            {
                retorno=0;
                *posicion=i;
                break;
            }
        }
    }
    return retorno;
}

int pantalla_alta(Pantalla array[], int size, int* contadorID)
{
    int retorno=-1;
    int posicion;
    if(array!=NULL && size>0 && contadorID!=NULL)
    {
        if(pantalla_buscarEmpty(array,size,&posicion)==-1)
        {
            printf("\nNo hay lugares vacios");
        }
        else
        {
        	array[posicion].isEmpty=0;
            utn_getInt(&array[posicion].tipo,"\n:Elija un tipo 1-Led/2-LCD: ","\nError",1,2,2);
            utn_getFloat(&array[posicion].precioPorDia,"\nPrecio por dia: ","\nError",100,2000,2);
            utn_getName("\nIngrese nombre de Pantalla: ","\nError",1,TEXT_SIZE,2,array[posicion].nombre);
            utn_getName("\nIngrese calle: ","\nError",1,TEXT_SIZE,2,array[posicion].direccion.calle);
            utn_getInt(&array[posicion].direccion.altura,"\nIngrese altura: ","\nError",1,3000,2);
            (*contadorID)++;
            array[posicion].idPantalla = *contadorID;
            printf("\n Posicion: %d"
            		"\n ID: %d"
            		"\n Tipo: %d"
            		"\n Precio por dia: %f"
            		"\n Nombre: %s"
            		"\n Calle: %s"
            		"\n Altura: %d",
                   posicion,
				   array[posicion].idPantalla,
				   array[posicion].tipo,
				   array[posicion].precioPorDia,
				   array[posicion].nombre,
				   array[posicion].direccion.calle,
				   array[posicion].direccion.altura);
            retorno=0;
        }
    }
    return retorno;
}

//*****************************************

int pantalla_baja(Pantalla pantArray[],Publicidad publiArray[], int sizePantArray, int sizePubliArray)
{
    int retorno=-1;
    int posicion;
    int id;
    if(pantArray!=NULL && sizePantArray>0 && publiArray!=NULL && sizePubliArray>0)
    {
    	utn_getInt(&id,"\nID de pantalla a dar de baja: ","\nError",1,10,1);
        if(pantalla_buscarID(pantArray,sizePantArray,id,&posicion)==-1)
        {
            printf("\nNo existe este ID");
        }
        else
        {
            pantArray[posicion].isEmpty=1;
            pantArray[posicion].idPantalla=0;
            pantArray[posicion].tipo=0;
            pantArray[posicion].precioPorDia=0;
            strcpy(pantArray[posicion].nombre,"");
            strcpy(pantArray[posicion].direccion.calle,"");
            pantArray[posicion].direccion.altura=0;
        }
        posicion = 0;
        for(int i=0;i<CANT_EMP;i++)
        {
        	if(publicidad_buscarID(publiArray,sizePubliArray,id,&posicion)==-1)
        	{
        	   printf("\nNo existe publicidad para dar de baja en esta pantalla");
        	}
        	else
        	{
        	   	publiArray[posicion].isEmpty=1;
        	   	publiArray[posicion].idPublicidad=0;
        	   	publiArray[posicion].cantDias=0;
        	    strcpy(publiArray[posicion].cuilCliente,"");
        	    strcpy(publiArray[posicion].nombrePublicidad,"");
        	}

        }
        retorno=0;
    }

   	return retorno;
}


int pantalla_modificar(Pantalla array[], int sizeArray)
{
    int retorno=-1;
    int posicion;
    int id;
    char opcion;
    if(array!=NULL && sizeArray>0)
    {
    	utn_getInt(&id,"\nID de pantalla a modificar: ","\nError",1,CANT_EMP,2);
        if(pantalla_buscarID(array,sizeArray,id,&posicion)==-1)
        {
            printf("\nNo existe este ID");
        }
        else
        {
            do
            {
            	printf("\n Posicion: %d"
            	            		"\n ID: %d"
            	            		"\n Tipo: %d"
            	            		"\n Precio por dia: %f"
            	            		"\n Nombre: %s"
            	            		"\n Calle: %s"
            	            		"\n Altura: %d",
            	                   posicion,
            					   array[posicion].idPantalla,
            					   array[posicion].tipo,
            					   array[posicion].precioPorDia,
            					   array[posicion].nombre,
            					   array[posicion].direccion.calle,
            					   array[posicion].direccion.altura);
                utn_getChar("\nModificar: Tipo(A) Precio por dia(B) Nombre(C) Calle(D) Altura(E) S(Salir)","\nError",'A','S',2,&opcion);
                switch(opcion)
                {
                    case 'A':
                    	utn_getInt(&array[posicion].tipo,"\n:Elija un tipo 1-Led/2-LCD: ","\nError",1,2,1);
                        break;
                    case 'B':
                        utn_getFloat(&array[posicion].precioPorDia,"\n:Precio por dia: ","\nError",100,2000,1);
                        break;
                    case 'C':
                        utn_getName("\nNombre: ","\nError",1,TEXT_SIZE,1,array[posicion].nombre);
                        break;
                    case 'D':
                    	utn_getName("\nCalle: ","\nError",1,TEXT_SIZE,1,array[posicion].direccion.calle);
                        break;
                    case 'E':
                    	utn_getInt(&array[posicion].direccion.altura,"\nAltura: ","\nError",1,3000,1);
                    	break;
                    case 'S':
                        break;
                    default:
                        printf("\nOpcion no valida");
                }
            }while(opcion!='S');
            retorno=0;
        }
    }
    return retorno;
}

//*****************************************

int pantalla_listar(Pantalla array[], int size)
{
    int retorno=-1;
    int i;
    if(array!=NULL && size>=0)
    {
        for(i=0;i<size;i++)
        {
            if(array[i].isEmpty==1)
                continue;
            else
            	printf("\n Posicion: %d"
            	       "\n ID: %d"
            	       "\n Tipo: %d"
            	       "\n Precio por dia: %f"
            	       "\n Nombre: %s"
            	       "\n Calle: %s"
            	       "\n Altura: %d",
            	       i,
            	       array[i].idPantalla,
            	       array[i].tipo,
            	       array[i].precioPorDia,
            	       array[i].nombre,
            	       array[i].direccion.calle,
            	       array[i].direccion.altura);
        }
        retorno=0;
    }
    return retorno;
}




