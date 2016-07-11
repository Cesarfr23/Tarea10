using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class RegistroCategorias : Form
    {
        Conexion conexion = new Conexion();
        Categorias categoria = new Categorias();

        public RegistroCategorias()
        {
            InitializeComponent();
        }

        private void RegistroCategorias_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Insertar(Convert.ToInt32(CategoriasIdTextBox.Text),DescripcionTextBox.Text);
            CategoriasIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CategoriasIdTextBox.Text.Length > 0)
            {
                categoria.CategoriaId = Convert.ToInt32(CategoriasIdTextBox.Text);
                categoria.Descripcion = DescripcionTextBox.Text;
            }
            else
            {
                categoria.Descripcion = DescripcionTextBox.Text;
                MessageBox.Show("Categoria Guardada.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoria.CategoriaId = Convert.ToInt32(CategoriasIdTextBox.Text);
            MessageBox.Show("Eliminado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            categoria.CategoriaId = Convert.ToInt32(CategoriasIdTextBox.Text);
        }
    }
}
