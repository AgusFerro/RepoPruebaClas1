using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class Ejercicio45
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMiMetodo()
        {
            MiClase.MiMetodo();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstructorMiClase()
        {
            //arrange
            MiClase mc;

            //act
            mc = new MiClase();
            //assert manejado en el ExcpetedExceptio
            
        }


        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestConstructorMiClaseInt()
        {
            //arrange
            MiClase mc;

            //act
            mc = new MiClase(0);
            //assert manejado en el ExcpetedExceptio

        }


        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestConstructorOtraClase()
        {
            //arrange
            OtraClase oc;

            //act
            oc = new OtraClase();
            //assert manejado en el ExcpetedExceptio

        }
    }
}
