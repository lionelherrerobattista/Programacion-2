using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComiqueriaLogic;

namespace TestComiqueriaException
{
    [TestClass]
    public class TestComiqueriaException
    {
        [TestMethod]
        public void ProbarComiqueriaException()
        {
            string ruta;

            Venta venta = new Venta();

            ruta = String.Format("{0}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            ruta = String.Format("{0}\\Parcial\\venta.xml", ruta);

            try
            {
                Serializador<Venta>.GuardarBinario(ruta, venta);
            }
            catch(ComiqueriaException e)
            {
                Assert.ReferenceEquals(e, typeof(ComiqueriaException));
            }

        }
    }
}
