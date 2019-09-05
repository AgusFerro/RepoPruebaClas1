/*
 * Clase-05.h
 *
 *  Created on: 4 sep. 2019
 *      Author: alumno
 */

#ifndef CLASE_05_H_
#define CLASE_05_H_

#define QTY_EDADES 5

int obtenerMayorArrayInt(int *pArray, int limite, int *pMayor);
int obtenerMenorArrayInt(int *pArray, int limite, int *pMenor);
int obtenerSumaYPromedioArrayInt(int *pArray, int limite, int *pSuma, int *pPromedio);
//A partir de este punto, termina mi biblioteca

int initArrayInt(int *pArray , int limite, int valor);
int printArrayInt(int *pArray , int limite);
int getArrayInt(	int *pArray,
					int limite,
					char *pMensaje,
					char *pMensajeError,
					int minimo,
					int maximo,
					int reintentos);
int getInt(	int *pResultado,
			char *pMensaje,
			char *pMensajeError,
			int minimo,
			int maximo,
			int reintentos);


#endif /* CLASE_05_H_ */
