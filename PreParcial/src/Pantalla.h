/*
 * Fantasma.h
 *
 *  Created on: 2 oct. 2019
 *      Author: agustin
 */

#ifndef PANTALLA_H_
#define PANTALLA_H_

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

int pantasma_buscarEmpty(Pantalla array[], int size, int* posicion);

int pantasma_buscarID(Pantalla array[], int size, int valorBuscado, int* posicion);

int pantasma_alta(Pantalla array[], int size, int* contadorID);

int pantasma_baja(Pantalla array[], int sizeArray);

int pantasma_modificar(Pantalla array[], int sizeArray);

int pantasma_listar(Pantalla array[], int size);


#endif // PANTALLA_H_INCLUDED
