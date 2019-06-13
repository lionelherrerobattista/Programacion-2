using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using System.Data.SqlClient;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public LocalDAO()
        {
            string connectionStr;

            connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog = Centralita; Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public Local Leer(int id)
        {
            string consulta;
            string origen;
            string destino;
            float costo;
            float duracion;


            Local auxLocal = null;



            consulta = String.Format("SELECT Duración, Origen, Destino, Costo FROM Llamadas WHERE Tipo = 0 AND ID = {0}", id);

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                while(oDr.Read())
                {
                    if(float.TryParse(oDr["Duración"].ToString(), out duracion))
                    {
                        origen = oDr["Origen"].ToString();
                        destino = oDr["Destino"].ToString();

                        if(float.TryParse(oDr["Costo"].ToString(), out costo))
                        {
                            auxLocal = new Local(origen, duracion, destino, costo);
                        }
                    }
                }

               
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {


                this.conexion.Close();
            }

             return auxLocal;
        }

        public bool Guardar(Local l)
        {
            string consulta;
            bool guardo = true;

            consulta = String.Format("INSERT INTO Llamadas (Duración, Origen, Destino, Costo, Tipo)"+
                " VALUES ('{0}','{1}','{2}','{3:0.00}','0')",
                l.Duracion, l.NroOrigen, l.NroDestino, l.Costo.ToString(System.Globalization.CultureInfo.InvariantCulture)); //Cambiar la coma decimal por el punto sino da error

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                guardo = false;

                throw e;
            }
            finally
            {

                this.conexion.Close();
            }


            return guardo;


        }
    }
}
