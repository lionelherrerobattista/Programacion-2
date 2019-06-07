using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades_Ejercicio_60
{
  public class Consulta
  {

    public static void Insert(string consulta)
    {
      SqlCommand comando;
      SqlConnection conexion;

      string connectionStr;

      connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog =AdventureWorks2012;" +
        " Integrated Security = True";

      conexion = new SqlConnection(connectionStr);

      comando = new SqlCommand();

      comando.CommandType = System.Data.CommandType.Text;

      comando.Connection = conexion;

      try
      {
        comando.CommandText = consulta;

        conexion.Open();

        comando.ExecuteNonQuery();

      }
      catch (Exception excepcion)
      {
        throw excepcion;
      }
      finally
      {
        conexion.Close();
      }
    }

    public static void Update(string consulta)
    {
      SqlCommand comando;
      SqlConnection conexion;

      string connectionStr;

      connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog =AdventureWorks2012;" +
        " Integrated Security = True";

      conexion = new SqlConnection(connectionStr);

      comando = new SqlCommand();

      comando.CommandType = System.Data.CommandType.Text;

      comando.Connection = conexion;

      try
      {
        comando.CommandText = consulta;

        conexion.Open();

        comando.ExecuteNonQuery();

      }
      catch (Exception excepcion)
      {
        throw excepcion;
      }
      finally
      {
        conexion.Close();
      }
    }
      

  }
}
