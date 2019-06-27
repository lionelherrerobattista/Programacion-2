using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GrupoDAO
    {
        public SqlConnection conexion;
        public SqlCommand comando;

        public GrupoDAO()
        {
            string connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog = mundial-sp-2018; Integrated Security = True";

            this.conexion = new SqlConnection(connectionStr);

            this.comando = new SqlCommand();

            this.comando.CommandType = System.Data.CommandType.Text;

            this.comando.Connection = this.conexion;

        }

    }
}
