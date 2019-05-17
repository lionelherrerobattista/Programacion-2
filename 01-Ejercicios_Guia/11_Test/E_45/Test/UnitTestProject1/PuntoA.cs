using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace UnitTestProject1
{
    [TestClass]
    public class PuntoA
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            bool capturoException = false;
            //Act
            try
            {
                MiClase.Dividir();
            }
            catch(Exception e)
            {
                //Assert
                Assert.ReferenceEquals(e, typeof(DivideByZeroException));
                capturoException = true;
            }

            if(capturoException == false)
            {
                Assert.Fail();
            }
        }
    }
}
