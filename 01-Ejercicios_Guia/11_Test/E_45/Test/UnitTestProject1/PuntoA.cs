using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace UnitTestProject1
{
    [TestClass]
    public class PuntoA
    {
        [TestMethod]
        public void TestDividir()
        {
            //Arrange
            bool capturoException = false;
            double resultado;
            int b = 0;

            //Act
            try
            {
                resultado = 10 / b;
            }
            catch (Exception e)
            {

                capturoException = true;
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException));

            }

            if(capturoException == false)
            {
                Assert.Fail();
            }
        }
    }
}
