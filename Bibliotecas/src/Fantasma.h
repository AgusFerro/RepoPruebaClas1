/*
 * Fantasma.h
 *
 *  Created on: 2 oct. 2019
 *      Author: agustin
 */

#ifndef FANTASMA_H_
#define FANTASMA_H_

#define TEXT_SIZE 20
#define CANT_EMP 100

typedef struct
{
    int idUnico;
    int isEmpty;
    //-----------------
    char varString[TEXT_SIZE];
    int varInt;
    float varFloat;
    char varChar;
    char varLongString[TEXT_SIZE];

}Fantasma;

int abmFantasma(void);
void imprimeMenu();
void imprimeMenuModif();
int fantasma_Inicializar(Fantasma array[], int size);                                    //cambiar fantasma
int fantasma_buscarEmpty(Fantasma array[], int size, int* posicion);                    //cambiar fantasma
int fantasma_buscarID(Fantasma array[], int size, int valorBuscado, int* posicion);                    //cambiar fantasma
int fantasma_buscarInt(Fantasma array[], int size, int valorBuscado, int* posicion);                    //cambiar fantasma
int fantasma_buscarString(Fantasma array[], int size, char* valorBuscado, int* indice);                    //cambiar fantasma
int fantasma_alta(Fantasma array[], int size, int* contadorID);                          //cambiar fantasma
int fantasma_baja(Fantasma array[], int sizeArray);                                      //cambiar fantasma
int fantasma_bajaValorRepetidoInt(Fantasma array[], int sizeArray, int valorBuscado);
int fantasma_modificar(Fantasma array[], int sizeArray);                                //cambiar fantasma
int fantasma_ordenarPorDobleCriterio(Fantasma array[],int size);                                  //cambiar fantasma
int fantasma_listar(Fantasma array[], int size);


#endif // FANTASMA_H_INCLUDED
