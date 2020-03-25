
#ifndef PUBLICIDAD_H_
#define PUBLICIDAD_H_

#define TEXT_SIZE 20

typedef struct
{
    int idPublicidad;
    int isEmpty;
    char cuilCliente[14];
    int cantDias;
    char nombrePublicidad[TEXT_SIZE];

}Publicidad;

int publicidad_Inicializar(Publicidad array[], int size);

int publicidad_buscarEmpty(Publicidad array[], int size, int* posicion);

int publicidad_buscarID(Publicidad array[], int size, int valorBuscado, int* posicion);

int publicidad_alta(Publicidad array[], int size, int contadorID);

int publicidad_baja(Publicidad array[], int sizeArray, int contadorID);

int publicidad_modificar(Publicidad array[], int sizeArray, int contadorID);

int publicidad_listar(Publicidad array[], int size);


#endif /* PUBLICIDAD_H_ */
