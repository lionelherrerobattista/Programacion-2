using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestCentralita
{
  /// <summary>
  /// Descripción resumida de TestLocalProvincia
  /// </summary>
  [TestClass]
  public class TestLocalProvincia
  {
    public TestLocalProvincia()
    {
      //
      // TODO: Agregar aquí la lógica del constructor
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Obtiene o establece el contexto de las pruebas que proporciona
    ///información y funcionalidad para la serie de pruebas actual.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    #region Atributos de prueba adicionales
    //
    // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
    //
    // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void TestMethod1()
    {
      //Arrange
      
      Llamada llamada1;
      Llamada llamada2;
      Llamada llamada3;
      Llamada llamada4;
      
      //Act

      llamada1 = new Local("111", 10, "222", 30);
      llamada2 = new Local(llamada1, 30);
      llamada3 = new Provincial("111", Provincial.Franja.Franja_1, 30, "222");
      llamada4 = new Provincial(Provincial.Franja.Franja_1, llamada3);

      //Assert
      Assert.AreEqual(llamada1, llamada2);
      Assert.AreNotEqual(llamada1, llamada3);
      Assert.AreNotEqual(llamada1, llamada4);

      Assert.AreNotEqual(llamada2, llamada3);
      Assert.AreNotEqual(llamada2, llamada4);

      Assert.AreEqual(llamada3, llamada4);

    }
  }
}
