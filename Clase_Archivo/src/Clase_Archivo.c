/*
 ============================================================================
 Name        : Clase_Archivo.c
 Author      : Agustin
 Version     :
 Copyright   : GLP 3
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

/* fopen("archivo.txt","w"); --> abre y borra el contenido del archivo y escribe
 * 					  ,"r"); --> abre y lee el contenido del archivo
 * 					  ,"w");
 * 					  ,"w");
 */

/* Funciones para escribir:
 * fwrite(); --> Binarios
 * fprintf(); --> Texto
 */

/* Funciones para leer:
 * fread(); --> Binarios
 * fscanf(); --> Texto
 */

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	FILE *pFile;
	int r;
	char var1[50],var3[50],var2[50],var4[50],var5[50];

	 pFile = fopen("archivo.txt","r");
	 if(pFile == NULL)
	 {
		 printf("El archivo no existe");
		 exit(EXIT_FAILURE);
	 }
	 do
	 {
		 r = fscanf(pFile,"%[^,],%[^,],%[^,],%[^,],%[^\n]\n",var1,var2,var3,var4,var5);
		 if(r==5)
			 printf("Lei: %s %s %s %s %s\n",var1,var2,var3,var4,var5);
		 else
			 break;
	 }while(!feof(pFile));
	 fclose(pFile);

	return 0;
}
