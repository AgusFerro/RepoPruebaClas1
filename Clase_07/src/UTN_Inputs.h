/*
 * UTN_Inputs.h
 *
 *  Created on: 11 sep. 2019
 *      Author: alumno
 */

#ifndef UTN_INPUTS_H_
#define UTN_INPUTS_H_

/*Descr: Solicita un entero por teclado
Param1: Valor devuelto validado
Param2: Mensaje para el ingreso del valor
Param3: Mensaje de error si ingresa un valor no valido
Param4: Rango mínimo valido para el ingreso
Param5: Rango mínimo valido para el ingreso
Param6: Cantidad de veces que puede ingresarlo con error
Para3: Valor con el que se inicializa
*/
int getInt(	int *pResultado, char *pMensaje, char *pMensajeError, int minimo, int maximo, int reintentos);


#endif /* UTN_INPUTS_H_ */
