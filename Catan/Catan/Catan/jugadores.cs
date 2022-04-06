using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Catan
{
    public partial class jugadores : Form
    {
        public jugadores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //METODO PARA REGRESAR AL MENU PRINCIPAL
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void buttonj1_Click(object sender, EventArgs e) //METODO PARA IR AL TEBLERO
        {
            this.Hide();

            juego frm = new juego();

            frm.Show();
        }

    }
}
