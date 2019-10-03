
#ifndef PUBLICIDAD_H_
#define PUBLICIDAD_H_

typedef struct
{
    int idPublicidad;
    int isEmpty;
    int cuilCliente;
    int cantDias;
    char nombrePubli[TEXT_SIZE];

}Publicidad;

int publicidad_Inicializar(Publicidad array[], int size);

int publicidad_buscarEmpty(Publicidad array[], int size, int* posicion);

int publicidad_buscarID(Publicidad array[], int size, int valorBuscado, int* posicion);

int publicidad_alta(Publicidad array[], int size, int* contadorID);

int publicidad_baja(Publicidad array[], int sizeArray);

int publicidad_modificar(Publicidad array[], int sizeArray);

int publicidad_listar(Publicidad array[], int size);


#endif /* PUBLICIDAD_H_ */
