using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CentralitaHerencia;

namespace EntidadesDAO
{
    public class ProvincialDAO
    {

        private SqlConnection conexion;
        private SqlCommand comando;

        public ProvincialDAO()
        {
            string connectionStr;

            connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog = Centralita; Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public Provincial Leer(int id)
        {
            string consulta;
            string origen;
            string destino;
            float costo;
            float duracion;


            Provincial auxLocal = null;



            consulta = String.Format("SELECT Duración, Origen, Destino, Costo FROM Llamadas WHERE Tipo = 1 AND ID = {0}", id);

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                while (oDr.Read())
                {
                    if (float.TryParse(oDr["Duración"].ToString(), out duracion))
                    {
                        origen = oDr["Origen"].ToString();
                        destino = oDr["Destino"].ToString();

                        if (float.TryParse(oDr["Costo"].ToString(), out costo))
                        {
                            auxLocal = new Provincial(origen, Provincial.Franja.Franja_1, duracion, destino);
                        }
                    }
                }


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }

            return auxLocal;
        }

        public bool Guardar(Provincial p)
        {
            string consulta;
            bool guardo = true;

            consulta = String.Format("INSERT INTO Llamadas (Duración, Origen, Destino, Costo, Tipo)" +
                "VALUES ('{0}','{1}','{2}','{3:0.00}',1)", p.Duracion, p.NroOrigen, p.NroDestino, p.CostoLlamada.ToString(System.Globalization.CultureInfo.InvariantCulture));

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();
            }
            catch (Exception e)
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
