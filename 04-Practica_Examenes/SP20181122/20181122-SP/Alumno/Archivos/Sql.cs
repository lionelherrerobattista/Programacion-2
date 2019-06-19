using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;


namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>>
  {
    private SqlCommand comando;
    private SqlConnection conexion;

    public Sql()
    {
      string conexionStr;

      conexionStr = "Data Source=patentes-sp-2018; Initial Catalog =Patentes; Integrated Security = True";

      this.conexion = new SqlConnection(conexionStr);

      this.comando = new SqlCommand();

      this.comando.CommandType = System.Data.CommandType.Text;

      this.comando.Connection = conexion; 
    }



    public void Guardar(string tabla, Queue<Patente> datos)
    {
      string consulta;

      foreach (Patente p in datos)
      {
        consulta = String.Format("INSERT INTO Patentes (patente, tipo) VALUES ('{0}','{1}')", p.CodigoPatente, p.TipoCodigo);

        comando.CommandText = consulta;

        conexion.Open();

        comando.ExecuteNonQuery();

      }


      
    }

    public void Leer(string tabla, out Queue<Patente> datos)
    {

      Patente auxPatente;
      
      SqlDataReader oDr;

      this.comando.CommandText = "SELECT patente, tipo FROM Patentes";

      this.conexion.Open();

      datos = new Queue<Patente>();

      oDr = this.comando.ExecuteReader();

      while(oDr.Read())
      {
        auxPatente = new Patente();

        auxPatente.CodigoPatente = oDr["patente"].ToString();

        switch(oDr["tipo"].ToString())
        {
          case "Mercosur":
            auxPatente.TipoCodigo = Patente.Tipo.Mercosur;
            break;
          case "Vieja":
            auxPatente.TipoCodigo = Patente.Tipo.Vieja;
            break;
        }

        datos.Enqueue(auxPatente);

      }
    }

  }
}
