using System;
using CentralitaHerencia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCentralita
{
  [TestClass]
  public class TestLista
  {
    [TestMethod]
    public void TestMethod1()
    {
      //Arrange
      Centralita nuevaCentral;
      //Act
       nuevaCentral = new Centralita("Telefónos");
      //Assert
      Assert.IsNotNull(nuevaCentral.Llamadas);

    }
  }
}
