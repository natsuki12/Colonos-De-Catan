﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Catan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                    //METODO PARA ABRIR UN FORM AL PRESIONAR EL BOTON JUGAR

            jugadores frm = new jugadores();

            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();                    //METODO PARA ABRIR UN FORM AL PRESIONAR EL BOTON OBJETIVO

            reglas frm = new reglas();

            frm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }


    }
}
