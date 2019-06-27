using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Entidades;
using System.Collections.Generic;

namespace SP_Test
{
    [TestClass]
    public class TestArchivoTexto
    {
        [TestMethod]
        public void GuardarTexto()
        {
            //Arrange
            Texto archivoTexto = new Texto();
            Patente p1 = new Patente("SUI302", Patente.Tipo.Vieja);

            Queue<Patente> cola = new Queue<Patente>();
            Queue<Patente> cola2 = new Queue<Patente>();

            cola.Enqueue(p1);
            try
            {
                archivoTexto.Guardar("archivoTest.txt", cola);
            }
            catch
            {
                Assert.Fail();
            }

            archivoTexto.Leer("archivoTest.txt", out cola2);

            Assert.AreEqual(cola.Dequeue().CodigoPatente, cola2.Dequeue().CodigoPatente);

        }
    }
}
