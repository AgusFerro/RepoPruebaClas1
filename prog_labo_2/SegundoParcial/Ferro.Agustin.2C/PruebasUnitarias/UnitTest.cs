using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using EntidadesDAO;
using Archivos;
using Formularios;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestSerializarTurnoEnXml()
        {
            //arrange
            Turnos auxTurno = new Turnos(1, 2, 3, "Prueba", DateTime.Now);
            Xml<Turnos> auxXml = new Xml<Turnos>();
            //act
            auxXml.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\TurnoXmlTest.xml", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            bool success = auxXml.Guardar(auxTurno);
            //assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void TestSerializarTurnoEnBinario()
        {
            //arrange
            Turnos auxTurno = new Turnos(1, 2, 3, "Prueba", DateTime.Now);
            Binario auxBinario = new Binario();
            //act
            auxBinario.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\TurnoBinarioTest.bin", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            bool success = auxBinario.Guardar(auxTurno);
            //assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void TestDeserializarTurnoEnXml()
        {
            //arrange
            Turnos auxTurno = new Turnos();
            Xml<Turnos> auxXml = new Xml<Turnos>();
            //act
            auxXml.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\TurnoXmlTest.xml", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            auxTurno = auxXml.Leer();
            //assert
            Assert.AreEqual(1,auxTurno.IdTurno);
        }

        [TestMethod]
        public void TestDeserializarTurnoEnBinario()
        {
            //arrange
            Turnos auxTurno = new Turnos();
            Binario auxBinario = new Binario();
            //act
            auxBinario.Ruta = String.Format("{0}\\SegundoParcialUtn\\TurnosClinica\\TurnoBinarioTest.bin", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            auxTurno = auxBinario.Leer();
            //assert
            Assert.AreEqual(1, auxTurno.IdTurno);
        }

        [TestMethod]
        public void TestAgregarUnTurno()
        {
            //arrange
            AgregarTurnoForm agregarTurnoForm = new AgregarTurnoForm();
            ListaTurnosForm listaTurnosForm = new ListaTurnosForm();
            TurnoProgresoForm turnoProgresoForm = new TurnoProgresoForm();
            //act
            agregarTurnoForm.AgregarTurno(new Turnos(1,2,3,"Test",DateTime.Now));
            //assert
            Assert.AreEqual(1, listaTurnosForm.ColaTurnos.Count);
        }
    }
}
