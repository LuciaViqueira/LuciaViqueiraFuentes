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
        Boolean comenzar = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comenzar)
            {
                pictureBox1.Image = Resources.friends;
            }
            else {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
               
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comenzar)
            {
                pictureBox2.Image = Resources.TheCrown;
            }
            else {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comenzar) {
                pictureBox3.Image = Resources.TheCrown;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (comenzar)
            {
                pictureBox4.Image = Resources.friends;
            }
            else {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            if (comenzar)
            {
                pictureBox5.Image = Resources.dark;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           

            if (comenzar)
            {
                pictureBox6.Image = Resources.dark;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           

            if (comenzar)
            {
                pictureBox7.Image = Resources.gilmoregirls;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (comenzar)
            {
                pictureBox8.Image = Resources.gilmoregirls;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            

            if (comenzar) {
                pictureBox9.Image = Resources.anatomiagrey;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
            if (comenzar)
            {
                pictureBox10.Image = Resources.hannahmontana;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
            if (comenzar)
            {
                pictureBox11.Image = Resources.codigolyoko;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            

            if (comenzar)
            {
                pictureBox12.Image = Resources.you;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           
            if (comenzar)
            {
                pictureBox13.Image = Resources.codigolyoko;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
          
            if (comenzar)
            {
                pictureBox14.Image = Resources.you;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
           
            if (comenzar)
            {
                pictureBox15.Image = Resources.anatomiagrey;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
            if (comenzar)
            {
                pictureBox16.Image = Resources.hannahmontana;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.imagenescontrol);
                }
            }
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
            if (tiempo == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.nivel);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.nivel);
                }
                
            }
            else {
                timer1.Enabled = true;
                comenzar = true;
            }
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
            }
            else {
                tiempo = 100;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
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
                if (comboBox1.SelectedIndex == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    MessageBox.Show(Idioma.cambiarnivel);
                }
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
                MessageBox.Show(Idioma.finalizar);

            }
                       
            else
            {
                label4.Text = tiempo.ToString();
            }
        }

     
    }
}
