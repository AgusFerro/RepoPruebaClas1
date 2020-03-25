#include <stdio.h>
#include <stdio_ext.h>
#include <stdlib.h>
#include <string.h>
#include "Inputs.h"

typedef struct
{
	int id;
	char nombre[20];
	char apellido[20];
	float sueldo;
	int legajo;
	int isEmpty;
}eEmpleado;

void mostrarEmpleados(eEmpleado** lista, int len);
eEmpleado* new_EmpleadoParam( int leg, char* nombre, char* apellido, float sueldo);
eEmpleado* new_Empleado();

int main()
{
	eEmpleado** lista = (eEmpleado**) malloc(sizeof(eEmpleado*));
	eEmpleado** pAuxEmpleado;
	int cont = 0;
	char resp='s';
	int bufLegajo;
	char bufNombre[20];
	char bufApellido[20];
	float bufSueldo;

    eEmpleado* nuevoEmpleado = new_Empleado();


	     printf("\nLegajo    Nombre       Apellido       Sueldo \n");
	     printf(" %5d   %10s   %10s  %8.2f\n", nuevoEmpleado->legajo, nuevoEmpleado->nombre, nuevoEmpleado->apellido, nuevoEmpleado->sueldo);
	     printf("\nDireccion de memoria: %p",&nuevoEmpleado);
	     printf("\n\n");


	    do
	    {
	        utn_getInt(&bufLegajo,"\nIngrese legajo del Empleado: ","\nError",1,900,3);

	        getString("\nIngrese nombre del Empleado: ","\nError",1,20,3,bufNombre);

	        utn_getName("\nIngrese apellido del Empleado: ","\nError",'a','Z',3,bufApellido);

	        utn_getFloat(&bufSueldo,"\nIngrese sueldo del Empleado: ","\nError",1000,90000,3);

	        nuevoEmpleado = new_EmpleadoParam(bufLegajo, bufNombre,bufApellido,bufSueldo);
	        if(nuevoEmpleado==NULL)
	        {
	        	exit(1);
	        }

	         // *(lista + cont) = *nuevoEmpleado;
	         *(lista + cont) = nuevoEmpleado;
	         //lista[cont] = nuevoEmpleado;

	         cont++;
	         pAuxEmpleado = (eEmpleado**) realloc(lista, sizeof(eEmpleado*) *(cont+1));
	         if(pAuxEmpleado == NULL)
	   	     {
	   	        exit(1);
	   	     }

	         lista = pAuxEmpleado;

	         utn_getChar("\nDesea continuar? n/s ","\nError",'n','s',3,&resp);

	    }while(resp == 's');



	    printf("\nLegajo        Nombre         Apellido     Sueldo \n");
	    mostrarEmpleados(lista, cont);

	    free(lista);
	    free(pAuxEmpleado);
	    free(nuevoEmpleado);


	return 0;
}

void mostrarEmpleados(eEmpleado** lista, int len)
{

for(int i=0; i <= len; i++){
    printf(" %5d   %10s   %15s     %8.2f\n", (*(lista + i))->legajo, (*(lista + i))->nombre, (*(lista + i))->apellido, (*(lista + i))->sueldo);
}
printf("\n\n");

}


eEmpleado* new_Empleado(){

eEmpleado* emp = (eEmpleado*)malloc( sizeof(eEmpleado));

if(emp != NULL){
    emp->legajo = 0;
    strcpy(emp->nombre, "");
    strcpy(emp->apellido, "");
    emp->sueldo = 0;

}
return emp;
}

eEmpleado* new_EmpleadoParam( int leg, char* nombre, char* apellido, float sueldo){

eEmpleado* emp = (eEmpleado*)malloc( sizeof(eEmpleado));

if(emp != NULL){
    emp->legajo = leg;
    strcpy(emp->nombre, nombre);
    strcpy(emp->apellido, apellido);
    emp->sueldo = sueldo;

}
return emp;
}
