using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        public void TestInstanciaListaLlamadas()
        {
            // arrange
            Centralita c;

            // act
            c = new Centralita("Asd");

            // assert
            Assert.IsNotNull(c.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestLlamadaLocalIgual()
        {
            // arrange
            Centralita c = new Centralita("Asd");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 15, "Rosario", 1.47f);

            // act
            c += l1;
            c += l2;

            // assert manejado en el ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestLlamadaProvincialIgual()
        {
            // arrange
            Centralita c = new Centralita("Asd");
            Provincial p1 = new Provincial("Bernal",Provincial.Franja.Franja_1, 30, "Rosario");
            Provincial p2 = new Provincial("Bernal",Provincial.Franja.Franja_3, 15, "Rosario");

            // act
            c += p1;
            c += p2;

            // assert manejado en el ExpectedException
        }

        [TestMethod]
        public void TestComparacionDeLlamadas()
        {
            // arrange
            Centralita c = new Centralita("Asd");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 15, "Rosario", 1.47f);
            Provincial p1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 30, "Rosario");
            Provincial p2 = new Provincial("Bernal", Provincial.Franja.Franja_3, 15, "Rosario");

            // act
            try
            {
                c += l1;
                c += l2;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }

            try
            {
                c += p1;
                c += p2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }

            // assert 
        }
    }
}
