using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComiqueriaLogic
{
    public class ComiqueriaDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;


        

        /// <summary>
        /// Constructor por defecto, establece la conexiòn
        /// </summary>
        public ComiqueriaDAO()
        {
            string connectionStr;

            connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog = Comiqueria; Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();

            this.comando.CommandType = System.Data.CommandType.Text;

            this.comando.Connection = this.conexion;
        }
        /// <summary>
        /// Guarda un producto en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Guardar(Producto p)
        {
            string consulta;

            bool guardo = true;

            consulta = String.Format("INSERT INTO Productos (Descripcion, Precio, Stock) VALUES ('{0}','{1}','{2})",
                p.Descripcion, p.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture), p.Stock);

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

            if(guardo == true)
            {
                eventoDAO.Invoke(AccionesDB.Insert);
            }

            return guardo;


        }

        /// <summary>
        /// Elimina un producto de la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Eliminar(Producto p)
        {
            string consulta;

            bool borro = true;

            consulta = String.Format("DELETE FROM Productos WHERE Codigo = {0}", p.Codigo);
                

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();
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

            if(borro == true)
            {
                eventoDAO.Invoke(AccionesDB.Delete);
            }

            return borro;
        }
        
        /// <summary>
        /// Lee todos los productos de la Base de datos
        /// </summary>
        /// <returns></returns>
        public List<Producto> Leer()
        {

            Producto auxProducto;
            List<Producto> auxLista = new List<Producto>();

            double precio;
            int codigo;
            string descripcion;
            int stock;
            


            string consulta = String.Format("SELECT Codigo, Descripcion, Precio, Stock FROM Productos");

            try
            {
                this.comando.CommandText = consulta;

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                while (oDr.Read())
                {
                    if (double.TryParse(oDr["Precio"].ToString(), out precio))
                    {
                        descripcion = oDr["Descripcion"].ToString();

                        if(Int32.TryParse(oDr["Codigo"].ToString(), out codigo))
                        {
                            if (Int32.TryParse(oDr["Stock"].ToString(), out stock))
                            {
                                auxProducto = new Producto(codigo, descripcion, stock, precio);

                                auxLista.Add(auxProducto);
                            }
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

            return auxLista;


        }

        public delegate void DelegadoDAO(AccionesDB acciones);

        public static event DelegadoDAO eventoDAO;

    }
}
