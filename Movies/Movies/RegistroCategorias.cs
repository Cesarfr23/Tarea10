﻿using System;
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
        public RegistroCategorias()
        {
            InitializeComponent();
        }

        private void RegistroCategorias_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
        }

    }
}
