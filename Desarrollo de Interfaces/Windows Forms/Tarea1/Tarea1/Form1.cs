using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1.Idiomas;
using Tarea1.Properties;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int tiempo;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Resources.friends;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.TheCrown;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.TheCrown;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.friends;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Resources.dark;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Resources.dark;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Resources.gilmoregirls;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Resources.gilmoregirls;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.anatomiagrey;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Resources.hannahmontana;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Resources.codigolyoko;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Resources.you;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Resources.codigolyoko;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Resources.you;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Resources.anatomiagrey;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Resources.hannahmontana;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                label1.Text = Idioma.idioma;
                label2.Text = Idioma.nombre;
                label3.Text = Idioma.tiempo;

                button1.Text = Idioma.facil;
                button2.Text = Idioma.medio;
                button3.Text = Idioma.dificil;
                button4.Text = Idioma.empezar;
            }
            if (comboBox1.SelectedIndex == 1) {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                label1.Text = Idioma.idioma;
                label2.Text = Idioma.nombre;
                label3.Text = Idioma.tiempo;

                button1.Text = Idioma.facil;
                button2.Text = Idioma.medio;
                button3.Text = Idioma.dificil;
                button4.Text = Idioma.empezar;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tiempo == 0) {
                MessageBox.Show("No se ha escogido el nivel");
            }
            else
            {
                timer1.Enabled = true;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;
                pictureBox15.Enabled = true;
                pictureBox16.Enabled = true;

            }
                

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) {
                MessageBox.Show("Ahora no se puede cambiar el nivel");
            }
            else {
                tiempo = 100;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("Ahora no se puede cambiar el nivel");
            }
            else
            {
                tiempo = 80;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("Ahora no se puede cambiar el nivel");
            }
            else
            {
                tiempo = 60;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     

            tiempo--;
            label4.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Fin de partida");

            }
                       
            else
            {
                label4.Text = tiempo.ToString();
            }
        }

     
    }
}
