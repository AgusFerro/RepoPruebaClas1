#include <stdio.h>
#include <stdlib.h>
#include <stdio_ext.h>
#include "LinkedList.h"
#include "Controller.h"
#include "Inputs.h"
#include "Validaciones.h"
#include "Empleado.h"

static int isLetras(char*pBuffer);
static int isInt(char *pBuffer);
static int isValidSueldo(int sueldo);
static int isValidId(int id);
static int isValidHoras(int horas);
static int isValidNombre(char* nombre);

/** \brief Crea un empleado
 * \return this Employee*
 */
Empleado* employee_new()
{
	Empleado* this;
	this=malloc(sizeof(Empleado));
	return this;
}

/** \brief Crea un empleado con parametros
 * \param id char*
 * \param nombre char*
 * \param horasTrabajadas int*
 * \param sueldo int*
 * \return this Employee*
 */
//Empleado* employee_newParametros(char* id,char* nombre,char* horasTrabajadas,char* sueldo)
Empleado* employee_newParametros(char* id,char* nombre,char* horasTrabajadas)
{
	Empleado* this;

	this=employee_new();
	if( isInt(id)==0 &&
		isLetras(nombre)==0 &&
		isInt(horasTrabajadas)==0 &&
		//isInt(sueldo)==0 &&
	    employee_setId(this,atoi(id))==0 &&
	    employee_setNombre(this,nombre)==0 &&
	    employee_setHorasTrabajadas(this,atoi(horasTrabajadas))==0)/* &&
	    employee_setSueldo(this,atoi(sueldo))==0)*/
	{
		return this;
	}
	else
	{
		printf("\nNo se pudo crear el empleado con parametros");
		return NULL;
	}
}

/** \brief Elimina un empleado
 * \param this Employee*
 * \return 0 todo bien -1 error
 */
int employee_delete(Empleado* this)
{
	int retorno=-1;

	if(this!=NULL)
	{
		free(this);
		retorno=0;
	}

	return retorno;
}

/** \brief Establece el ID de un empleado
 * \param this Employee*
 * \param id int
 * \return 0 todo bien -1 error
 */
int employee_setId(Empleado* this,int id)
{
	int retorno=-1;
	static int proximoId=-1;

	if(this!=NULL && id==-1 && isValidId(id)==0)
	{
	   proximoId++;
	   this->id=proximoId;
	   retorno=0;
	}
	else
	{
	   this->id=id;
	   retorno=0;
	}

	if(id>proximoId)
	{
	   proximoId=id;
	   retorno=0;
	}
	return retorno;
}

/** \brief Devuelve el ID de un empleado
 * \param this Employee*
 * \param id int*
 * \return 0 todo bien -1 error
 */
int employee_getId(Empleado* this,int* id)
{
	int retorno = -1;

	if(this != NULL)
	{
        *id = this->id;
        retorno = 0;
    }
    return retorno;
}

/** \brief Establece el nombre de un empleado
 * \param this Employee*
 * \param nombre char*
 * \return 0 todo bien -1 error
 */
int employee_setNombre(Empleado* this,char* nombre)
{
	int retorno = -1;
	if(this != NULL && isValidNombre(nombre)==0)
	{
		strncpy(this->nombre,nombre,sizeof(this->nombre));
		retorno = 0;
	}
	else
	{
		printf("\nNo se pudo establecer el nombre");
	}
	return retorno;
}

/** \brief Devuelve el nombre de un empleado
 * \param this Employee*
 * \param nombre char*
 * \return 0 todo bien -1 error
 */
int employee_getNombre(Empleado* this,char* nombre)
{
	int retorno = -1;
	if(this != NULL)
	{
	   strcpy(nombre,this->nombre);
	   retorno = 0;
	}
	return retorno;
}

/** \brief Establece las horas trabajadas de un empleado
 * \param this Employee*
 * \param horasTrabajadas int
 * \return 0 todo bien -1 error
 */
int employee_setHorasTrabajadas(Empleado* this,int horasTrabajadas)
{
	int retorno = -1;
	if(this != NULL && horasTrabajadas >= 0)
	{
		this->horasTrabajadas = horasTrabajadas;
		retorno = 0;
	}
	else
	{
		printf("\nNo se pudo establecer las horas trabajadas");
	}
	return retorno;
}

/** \brief Devuelve las horas trabajadas de un empleado
 * \param this Employee*
 * \param horasTrabajadas int*
 * \return 0 todo bien -1 error
 */
int employee_getHorasTrabajadas(Empleado* this,int* horasTrabajadas)
{
	int retorno = -1;
	if(this != NULL)
	{
		*horasTrabajadas = this->horasTrabajadas;
		retorno = 0;
	}
	return retorno;
}

/** \brief Establece el sueldo de un empleado
 * \param this Employee*
 * \param sueldo int
 * \return 0 todo bien -1 error
 */
int employee_setSueldo(Empleado* this,int sueldo)
{
	int retorno = -1;
	if(this != NULL && sueldo >= 0)
	{
		this->sueldo = sueldo;
		retorno = 0;
	}
	else
	{
		printf("\nNo se pudo establecer el sueldo");
	}
	return retorno;
}

/** \brief Devuelve el sueldo de un empleado
 * \param this Employee*
 * \param sueldo int*
 * \return 0 todo bien -1 error
 */
int employee_getSueldo(Empleado* this,int* sueldo)
{
	int retorno = -1;
	if(this != NULL)
	{
		*sueldo = this->sueldo;
		retorno = 0;
	}
	return retorno;
}

/** \brief Valida los datos de un empleado
 * \param pEmpleado Employee*
 * \return 0 todo bien -1 error
 */
int employee_validarEmpleado(Empleado* pEmpleado)
{
    int retorno=-1;

    if(isValidId(pEmpleado->id)==0 &&
       isValidNombre(pEmpleado->nombre)==0 &&
       isValidHoras(pEmpleado->horasTrabajadas)==0 &&
       isValidSueldo(pEmpleado->sueldo)==0)
    {
       retorno=0;
    }
    else
    {
    	printf("\nNo se pudo validar el empleado");
    }
    return retorno;
}

/** \brief Busca el maximo Id de una lista
 * \param pArrayListEmployee LinkedList*
 * \return 0 todo bien -1 error
 */
int employee_buscarMaxId(LinkedList* pArrayListEmployee)
{
    int retorno=-1;
    int len;
    int i;
    int bufferId, idMax=0;
    Empleado* bufferEmployee;

    if(pArrayListEmployee != NULL)
    {
        len=ll_len(pArrayListEmployee);
        for(i=0;i<len;i++)
        {
            bufferEmployee=(Empleado*)ll_get(pArrayListEmployee,i);
            employee_getId(bufferEmployee,&bufferId);
            if(idMax<bufferId)
            {
            	idMax=bufferId;
            }
        }
        retorno=idMax;
    }
    return retorno;
}

/** \brief Valida un numero entero
 * \param pBuffer char* cadena a validar
 * \return 0 todo bien -1 error
 */
static int isInt(char *pBuffer)
{
    int retorno=-1;

    for(int i=0;i<strlen(pBuffer);i++)
    {
        if(pBuffer[i]<'0' || pBuffer[i]>'9')
        {
        	printf("\nNo es un numero");
            break;
        }
        retorno = 0;
    }

    return retorno;
}
/** \brief Valida un nombre valido (acepta nombres compuestos)
 * \param pBuffer char* cadena a validar
 * \return 0 todo bien -1 error
 */
static int isLetras(char*pBuffer)
{
    int retorno=-1;

    for(int i=0;i<strlen(pBuffer);i++)
    {
        if((pBuffer[i]<'A' || pBuffer[i]>'Z') && (pBuffer[i]<'a' || pBuffer[i]>'z') && pBuffer[i]!=' ' && pBuffer[i]!='-')
        {
        	printf("\nNo son letras %d",i);
            break;
        }

        retorno = 0;
    }
    return retorno;
}
/** \brief Valida un nombre para guardar en el campo nombre
 * \param nombre char* cadena a validar
 * \return 0 todo bien -1 error
 */
static int isValidNombre(char* nombre)
{
    int retorno=-1;
    if(nombre!= NULL && strlen(nombre)<50 && strlen(nombre)>1)
    {
        retorno=0;
    }
    else
    {
    	printf("\nNombre supera los limites");
    }
    return retorno;
}
/** \brief Valida una hora valida
 * \param horas int
 * \return 0 todo bien -1 error
 */
static int isValidHoras(int horas)
{
    int retorno=-1;
    if(horas>0)
    {
        retorno=0;
    }
    return retorno;
}
/** \brief Valida un id valido
 * \param id int
 * \return 0 todo bien -1 error
 */
static int isValidId(int id)
{
    int retorno=-1;
    if(id>0)
    {
        retorno=0;
    }
    return retorno;
}
/** \brief Valida un sueldo valido
 * \param sueldo int
 * \return 0 todo bien -1 error
 */
static int isValidSueldo(int sueldo)
{
    int retorno=-1;
    if(sueldo>0)
    {
        retorno=0;
    }
    return retorno;
}


int em_calcularSueldo(void* p)
{
	int returnAux=-1;
	int horas;
	int sueldo;

	if(p!=NULL)
	{
		employee_getHorasTrabajadas(p,&horas);
		if(horas<=120)
		{
			sueldo=horas*180;
		}
		else if(horas>120 && horas<=160)
		{
			horas=horas-120;
			sueldo=(horas*240)+(120*180);
		}
		else if(horas>160)
		{
			horas=horas-160;
			sueldo=(horas*350)+(40*240)+(120*180);
		}

		if(employee_setSueldo(p,sueldo)==0)
		{
			returnAux=0;
		}
	}
	// recibo elemento empleado como void.
	// hacer calculo de sueldo y escribirlo en campo sueldo del empleado
	return returnAux;
}

int criterioSueldo(void* p)
{
    int sueldo;
    int orden=-1;

    employee_getSueldo(p,&sueldo);
    if(sueldo>30000)
    {
    	orden=1;
    }

    return orden;
}
