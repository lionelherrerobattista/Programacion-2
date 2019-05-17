using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestCentralita
{
  /// <summary>
  /// Si se lanza CentralitaException al cargar una segunda llamada
  /// Local con los mismos datos de la anterior
  /// </summary>
  [TestClass]
  public class TestProvincialRepetida
  {
    public TestProvincialRepetida()
    {
      //Arrange
      Centralita nuevaCentral;
      Llamada llamada1;
      Llamada llamada2;
      bool atrapoExcepcion = false;
      //Act
      nuevaCentral = new Centralita("Nueva Central");
      llamada1 = new Provincial("111", Provincial.Franja.Franja_1, 20, "222");
      llamada2 = new Provincial("111", Provincial.Franja.Franja_2, 45, "222");

      try
      {
        nuevaCentral = nuevaCentral + llamada1;
        nuevaCentral = nuevaCentral + llamada1;
      }
      catch (Exception e)
      {
        //Assert
        atrapoExcepcion = true;
        Assert.ReferenceEquals(e, typeof(CentralitaException));
      }

      if (atrapoExcepcion == false)
      {
        Assert.Fail();
      }
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
      //
      // TODO: Agregar aquí la lógica de las pruebas
      //
    }
  }
}
