/*
 * UTN_Array.h
 *
 *  Created on: 11 sep. 2019
 *      Author: alumno
 */

#ifndef UTN_ARRAY_H_
#define UTN_ARRAY_H_

#define CANT_EL 4

/*Descr: Inicializa un Array de enteros
Param1: Array por referencia
Param2: Elementos del Array
Para3: Valor con el que se inicializa
*/
int initArrayInt(int *pArray , int limite, int valor);

/*Descr: Imprime un Array de enteros
Param1: Array por referencia
Param2: Elementos del Array
*/
int printArrayInt(int *pArray , int limite);

/*Descr: Carga un Array de enteros
Param1: Array por referencia
Param2: Elementos del Array
Param3: Parametros funcion getInt()
*/
int getArrayInt(int *pArray, int limite,char *pMensaje,char *pMensajeError,int minimo,int maximo,int reintentos);

/*Descr: Busca el minimo y maximo en un array
Param1: Array por referencia
Param2: Elementos del Array
Param3: minimo a devolver por referencia
Param4: maximo a devolver por referencia
*/
int minMaxArrayInt(int* pArray,int limite,int* minimo,int* maximo);

/*Descr: Suma los elementos de un array
Param1: Array por referencia
Param2: Elementos del Array
Param3: la suma
*/
int sumaArrayInt(int* pArray,int limite,int* resultado);

/*Descr: Promedio de los elementos de un array
Param1: Array por referencia
Param2: Elementos del Array
Param3: el promedio
*/
int promedioArrayInt(int* pArray,int limite,int* resultadoProm);

/*Descr: Ordena los elementos de un array
Param1: Array por referencia
Param2: Elementos del Array
*/
int OrdenaArrayInt(int* pArray,int limite);

int cargarSetDatos(char pArrayNombre[][50], int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite);

int mostrarEstudiante(char pArrayNombre[50],int aLegajo, char aSexo, int aEdad, int aNota1P,int aNota2P, float aPromedio);

int mostrarEstudiantes(char pArrayNombre[][50],int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite);

int ordenarLegajoEstudiantes(char pArrayNombre[][50],int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite, int orden);

int ordenarPromedioEstudiantes(char pArrayNombre[][50],int* aLegajo, char* aSexo,int* aEdad,int* aNota1P,int* aNota2P, float* aPromedio,int limite);


#endif /* UTN_ARRAY_H_ */
