################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/Inputs.c \
../src/Pantalla.c \
../src/PreParcial.c \
../src/Publicidad.c \
../src/Validaciones.c 

OBJS += \
./src/Inputs.o \
./src/Pantalla.o \
./src/PreParcial.o \
./src/Publicidad.o \
./src/Validaciones.o 

C_DEPS += \
./src/Inputs.d \
./src/Pantalla.d \
./src/PreParcial.d \
./src/Publicidad.d \
./src/Validaciones.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: GCC C Compiler'
	gcc -O0 -g3 -Wall -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


