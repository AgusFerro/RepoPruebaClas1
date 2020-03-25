/*
 * Clase-05.h
 *
 *  Created on: 4 sep. 2019
 *      Author: alumno
 */

#ifndef CLASE_06_H_
#define CLASE_06_H_

#define QTY_EDADES 5
#define largo 6

int obtenerMayorArrayInt(int *pArray, int limite, int *pMayor);
int obtenerMenorArrayInt(int *pArray, int limite, int *pMenor);
int obtenerSumaYPromedioArrayInt(int *pArray, int limite, int *pSuma, int *pPromedio);
//A partir de este punto, termina mi biblioteca

int initArrayInt(int *pArray , int limite, int valor);
// Inicializa un Array

int printArrayInt(int *pArray , int limite);
// Muestra todos los valores de una Array por pantalla

int getArrayInt(	int *pArray,
					int limite,
					char *pMensaje,
					char *pMensajeError,
					int minimo,
					int maximo,
					int reintentos);
// Carga Array con enteros, con un maximo,minimo y cant de reintentos para validar

int getInt(	int *pResultado,
			char *pMensaje,
			char *pMensajeError,
			int minimo,
			int maximo,
			int reintentos);
//Pide un numero, con un maximo,minimo y cant de reintentos para validar

int ordenamientoArrayInt(int *pArray, int limite);
//Ordena un Array por burbujeo de menor a mayor

int ordenamientoEficienteArrayInt(int *pArray, int limite);
//Ordena un Array por burbujeo eficiente de menor a mayor


#endif /* CLASE_06_H_ */
