/*
 * Fantasma.h
 *
 *  Created on: 2 oct. 2019
 *      Author: agustin
 */

#ifndef PANTALLA_H_
#define PANTALLA_H_
#include "Publicidad.h"

#define TEXT_SIZE 20
#define CANT_EMP 100

typedef struct
{
    char calle[TEXT_SIZE];
    int altura;

}Direccion;

typedef struct
{
    int idPantalla;
    int isEmpty;
    char nombre[TEXT_SIZE];
    int tipo; // 1-LCD 2-Led
    Direccion direccion;
    float precioPorDia;

}Pantalla;

int abmFantasma(void);
void imprimeMenu();
void imprimeMenuModif();

int pantalla_Inicializar(Pantalla array[], int size);

int pantalla_buscarEmpty(Pantalla array[], int size, int* posicion);

int pantalla_buscarID(Pantalla array[], int size, int valorBuscado, int* posicion);

int pantalla_alta(Pantalla array[], int size, int* contadorID);

int pantalla_baja(Pantalla pantArray[],Publicidad publiArrary[], int sizePantArray, int sizePubliArray);

int pantalla_modificar(Pantalla array[], int sizeArray);

int pantalla_listar(Pantalla array[], int size);


#endif // PANTALLA_H_INCLUDED
