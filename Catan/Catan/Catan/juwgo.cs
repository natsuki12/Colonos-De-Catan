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
    public partial class juego : Form
    {

        public juego()
        {
          InitializeComponent();
        }

        private void juego_Load(object sender, EventArgs e)
        {
          
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)   //METODO PARA EL DADO1
        {
            int dado1;
            Random ale = new Random();
            dado1 = ale.Next(1,7);
            if (dado1 == 1)
            {
                pidado1.Image = Image.FromFile("dado1.png");
                pictureBox7.Image = Image.FromFile("ficha morada.png");
                this.pictureBox7.Visible = true;
                this.pictureBox2.Visible = false;

            }
            if (dado1 == 2)
            {
                pidado1.Image = Image.FromFile("dado2.png");
                pictureBox9.Image = Image.FromFile("ficha morada.png");
                this.pictureBox9.Visible = true;
                this.pictureBox2.Visible = false;
            }
            if (dado1 == 3)
            {
                pidado1.Image = Image.FromFile("dado3.png");
                pictureBox5.Image = Image.FromFile("ficha morada.png");
                this.pictureBox5.Visible = true;
                this.pictureBox2.Visible = false;
            }
            if (dado1 == 4)
            {
                pidado1.Image = Image.FromFile("dado4.png");
                pictureBox31.Image = Image.FromFile("ficha morada.png");
                this.pictureBox4.Visible = true;
                this.pictureBox2.Visible = false;
            }
            if (dado1 == 5)
            {
                pidado1.Image = Image.FromFile("dado5.png");
                pictureBox30.Image = Image.FromFile("ficha morada.png");
                this.pictureBox30.Visible = true;
                this.pictureBox2.Visible = false;
            }
            if (dado1 == 6)
            {
                pidado1.Image = Image.FromFile("dado6.png");
                pictureBox20.Image = Image.FromFile("ficha morada.png");
                this.pictureBox20.Visible = true;
                this.pictureBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e) //METODO PARA EL DADO 2
        {
            int dado2;
            Random ale = new Random();
            dado2 = ale.Next(1,7);
            if (dado2 == 1)
            {
                pidado2.Image = Image.FromFile("dado1.png");

            } if (dado2 == 2)
            {
                pidado2.Image = Image.FromFile("dado2.png");

            } if (dado2 == 3)
            {
                pidado2.Image = Image.FromFile("dado3.png");

            } if (dado2 == 4)
            {
                pidado2.Image = Image.FromFile("dado4.png");

            } if (dado2 == 5)
            {
                pidado2.Image = Image.FromFile("dado5.png");

            } if (dado2 == 6)
            {
                pidado2.Image = Image.FromFile("dado6.png");

            }
        }


    }
}
