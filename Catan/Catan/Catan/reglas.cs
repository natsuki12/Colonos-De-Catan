﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Catan
{
    public partial class reglas : Form
    {
        public reglas()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                    //METODO PARA ABRIR UN FORM AL PRESIONAR EL BOTON JUGAR

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
