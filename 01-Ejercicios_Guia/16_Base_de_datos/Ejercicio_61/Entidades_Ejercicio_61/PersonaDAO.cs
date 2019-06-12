using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace Entidades_Ejercicio_61
{
    public class PersonaDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public PersonaDAO()
        {
            //Configuro la conexión
            string connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog =Persona; Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            //Asocio el comando a la conexión
            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;

        }

        public bool Guardar(Persona p)
        {
            string consulta;
            bool guardo = true;

            consulta = String.Format("INSERT INTO Persona (Nombre, Apellido) VALUES ('{0}','{1}')", p.Nombre, p.Apellido);

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                comando.ExecuteNonQuery();
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

        public List<Persona> Leer()
        {
            string consulta;
            string nombre;
            string apellido;
            int id;

            Persona auxPersona;

            List<Persona> listaPersonas = new List<Persona>();


            consulta = "SELECT ID, Nombre, Apellido FROM Persona";

            try
            {
                this.comando.CommandText = consulta;

                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while(oDr.Read())
                {
                    if(Int32.TryParse(oDr["ID"].ToString(), out id))
                    {
                        nombre = oDr["Nombre"].ToString();

                        apellido = oDr["Apellido"].ToString();

                        auxPersona = new Persona(id, nombre, apellido);

                        listaPersonas.Add(auxPersona);
                    }

                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }


            return listaPersonas;
        }

        public Persona LeerPorID(int id)
        {
            string consulta;
            string nombre = "";
            string apellido = "";

            Persona auxPersona;


            consulta = String.Format("SELECT Nombre, Apellido FROM Persona WHERE ID = {0}", id);

            try
            {
                this.comando.CommandText = consulta;

                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {

                    nombre = oDr["Nombre"].ToString();

                    apellido = oDr["Apellido"].ToString();
                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                auxPersona = new Persona(nombre, apellido);

                conexion.Close();
            }

            return auxPersona;
        }

        public bool Modificar(int id, string nombre, string apellido)
        {
            string consulta;
            bool modifico = true;

            consulta = String.Format("UPDATE Persona SET Nombre = '{0}', Apellido = '{1}' WHERE ID = {2}", nombre, apellido, id);

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                modifico = false;
                throw e;
            }
            finally
            {

                this.conexion.Close();
            }

            return modifico;
        }

        public bool Borrar(int id)
        {
            string consulta;
            bool borro = true;

            consulta = String.Format("DELETE FROM Persona WHERE ID = {0}", id);

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                borro = false;
                throw e;
            }
            finally
            {

                this.conexion.Close();
            }

            return borro;
        }
    }
}
