using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Movies
{
    class Conexion
    {
        public Conexion()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-4ECK98H\\SQLEXPRESS;Initial Catalog=Peliculas;Integrated Security=True");
                sqlConnection.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se Conecto con la Base de Datos: "+ex.ToString());
            }
        }
    }
}
