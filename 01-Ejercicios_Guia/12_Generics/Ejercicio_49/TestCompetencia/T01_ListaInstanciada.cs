using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Ejercicio_36;

namespace TestCompetencia
{
    [TestClass]
    public class T01_ListaInstanciada
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Competencia competenciaTest;
            //Act
            competenciaTest = new Competencia(10, 20, Competencia.TipoCompetencia.F1);

            //Assert
            Assert.IsNotNull(competenciaTest.Competidores);
        }
    }
}
