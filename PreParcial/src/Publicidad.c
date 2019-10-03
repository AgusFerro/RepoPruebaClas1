#include <string.h>
#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include "Inputs.h"
#include "Publicidad.h"
#include "Pantalla.h"

int publicidad_Inicializar(Publicidad array[], int size)
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

int publicidad_buscarEmpty(Publicidad array[], int size, int* posicion)
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


int publicidad_buscarID(Publicidad array[], int size, int valorBuscado, int* posicion)
{
    int retorno=-1;
    int i;
    if(array!= NULL && size>=0)
    {
        for(i=0;i<size;i++)
        {
            if(array[i].isEmpty==1)
                continue;
            else if(array[i].idPublicidad==valorBuscado)
            {
                retorno=0;
                *posicion=i;
                break;
            }
        }
    }
    return retorno;
}

int publicidad_alta(Publicidad array[], int size, int contadorID)
{
    int retorno=-1;
    int posicion;
    if(array!=NULL && size>0 && contadorID>0)
    {
        if(publicidad_buscarEmpty(array,size,&posicion)==-1)
        {
            printf("\nNo hay lugares vacios");
        }
        else
        {
        	array[posicion].isEmpty=0;
            utn_getInt(&array[posicion].idPublicidad,"\n:Elija una pantalla: ","\nNo existe la pantalla",1,contadorID,2);
            utn_getInt(&array[posicion].cantDias,"\n:Ingrese cantidad de dias(hasta 365): ","\nError",1,365,2);
            utn_getName("\nIngrese nombre de Publicidad ","\nError",1,TEXT_SIZE,2,array[posicion].nombrePublicidad);
            utn_getCUIT("\nIngrese Cuil: XX-XXXXXXXX-X","\nError",2,array[posicion].cuilCliente);
            printf("\n _Posicion: %d _ID: %d _Cantidad de dias %d _Nombre publicidad %s _Cuil %s",
                   posicion,
				   array[posicion].idPublicidad,
				   array[posicion].cantDias,
				   array[posicion].nombrePublicidad,
				   array[posicion].cuilCliente);
            retorno=0;
        }
    }
    return retorno;
}

//*****************************************

int publicidad_baja(Publicidad array[], int sizeArray,int contadorID)
{
    int retorno=-1;
    int posicion;
    int id;
    int flag = 0;
    char cuit[14];
    if(array!=NULL && sizeArray>0)
    {
    	utn_getCUIT("Ingrese CUIT de Cliente","Error",2,cuit);
    	for(int i=0;i<sizeArray;i++)
    	{
    	    if(array[i].isEmpty==0 && strcmp(array[i].cuilCliente,cuit)==0)
    	    {
    	    	printf("\n Posicion: %d"
    	  		       "\n ID: %d"
      			       "\n Cantidad de dias: %d",
  	    			       posicion,
    	    		       array[posicion].idPublicidad,
    	    		       array[posicion].cantDias);
    	    			   flag++;
    	    		}
    	    	}
    	    	if(flag>0)
    	    	{
    	    		utn_getInt(&id,"\nID de pantalla a dar de baja: ","\nError",1,contadorID,2);
    	    		if(pantalla_buscarID(array,sizeArray,id,&posicion)==-1)
    	    		{
    	    			printf("\nNo existe este ID");
    	    		}
    	    		else
    	    		{
    	    			array[posicion].isEmpty=1;
    	    			array[posicion].idPublicidad=0;
    	    			array[posicion].cantDias=0;
    	    			strcpy(array[posicion].nombrePublicidad,"");
    	    			strcpy(array[posicion].cuilCliente,"");
    	            	retorno=0;
    	    		}
    	    	}
    }
    return retorno;
}


int publicidad_modificar(Publicidad array[], int sizeArray, int contadorID)
{
    int retorno=-1;
    int posicion;
    int id;
    int flag=0;
    char cuit[14];

    if(array!=NULL && sizeArray>0)
    {
    	utn_getCUIT("Ingrese CUIT de Cliente","Error",2,cuit);
    	for(int i=0;i<sizeArray;i++)
    	{
    		if(array[i].isEmpty==0 && strcmp(array[i].cuilCliente,cuit)==0)
    		{
    			printf("\n Posicion: %d"
    			       "\n ID: %d"
    			       "\n Cantidad de dias: %d",
    			       posicion,
    			       array[posicion].idPublicidad,
    			       array[posicion].cantDias);
    					flag++;
    		}
    	}
    	if(flag>0)
    	{
    		utn_getInt(&id,"\nID de pantalla a modificar: ","\nError",1,contadorID,2);
    		if(pantalla_buscarID(array,sizeArray,id,&posicion)==-1)
    		{
    			printf("\nNo existe este ID");
    		}
    		else
    		{
    			printf("\n Posicion: %d"
    					"\n ID: %d"
    					"\n Cantidad de dias: %d",
						posicion,
						array[posicion].idPublicidad,
						array[posicion].cantDias);
            			utn_getInt(&array[posicion].cantDias,"\n:Ingrese cantidad de dias: (hasta 365) ","\nError",1,365,2);
            			retorno=0;
    		}
    	}
    }
    return retorno;
}

//*****************************************

int publicidad_listar(Publicidad array[], int size)
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
            	       "\n Cantidad de dias: %d"
            	       "\n Nombre: %s"
            	       "\n Cuil: %s",
            	       	i,
            	        array[i].idPublicidad,
            	        array[i].cantDias,
            	        array[i].nombrePublicidad,
            	        array[i].cuilCliente);
        }
        retorno=0;
    }
    return retorno;
}

int consultar_facturacion (Pantalla pantArray[],Publicidad publiArray[], int sizePantArray, int sizePubliArray)
{
    int retorno=-1;
    int posicion;
    int id;
    char cuit[14];

    if(pantArray!=NULL && sizePantArray>0)
    {
    	utn_getCUIT("Ingrese CUIT de Cliente","Error",2,cuit);
    	for(int i=0;i<sizePubliArray;i++)
    	{
    		if(publiArray[i].isEmpty==0 && strcmp(publiArray[i].cuilCliente,cuit)==0)
    		{
    			pantalla_buscarID(Pantalla array[], int size, int valorBuscado, int* posicion)
    		}
    	}


    }
    return retorno;
}

//*****************************************

