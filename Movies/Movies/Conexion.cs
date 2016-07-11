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
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public Conexion()
        {
            try
            {
                sqlConnection = new SqlConnection("Data Source=DESKTOP-4ECK98H\\SQLEXPRESS;Initial Catalog=Peliculas;Integrated Security=True");
                sqlConnection.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se Conecto con la Base de Datos: "+ex.ToString());
            }
        }

        public string Insertar(int CategoriaId, string Descripcion)
        {
            string salida = "Si se inserto";
            try
            {
                sqlCommand = new SqlCommand("Insert into Categoria(CategoriaId, Descripcion) values("+CategoriaId+", '"+Descripcion+"')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se inserto" + ex.ToString();

            }
            return salida;
        }
    }
}
