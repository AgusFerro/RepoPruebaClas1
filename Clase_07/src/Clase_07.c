#include <stdio.h>
#include <stdlib.h>
#include "UTN_Array.h"
#include "UTN_Inputs.h"


int main()
{
int legajo[CANT_EL];
char sexo[CANT_EL];
int edad[CANT_EL];
int nota1P[CANT_EL];
int nota2P[CANT_EL];
float promedio[CANT_EL];
char arrayNombres[CANT_EL][50];



    cargarSetDatos(arrayNombres, legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL);
    //Mostrar ordenar y mostrar
    mostrarEstudiantes(arrayNombres,legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL);
    //orden=1 ascendente, orden=2 descendente
    ordenarLegajoEstudiantes(arrayNombres,legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL, 2);
    mostrarEstudiantes(arrayNombres,legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL);
    //Si el promedio se repita, ordeno por nombre de manera ascendente
    ordenarPromedioEstudiantes(arrayNombres,legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL);
    mostrarEstudiantes(arrayNombres,legajo, sexo, edad, nota1P, nota2P, promedio, CANT_EL);

    return 0;

}


