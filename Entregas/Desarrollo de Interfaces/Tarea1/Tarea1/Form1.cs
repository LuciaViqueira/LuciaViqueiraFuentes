using System;
using System.Collections;
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
        List<PictureBox> imagenes = new List<PictureBox>();
        PictureBox pictureBox1ant; 
        PictureBox pictureBox2ant;

        bool primeraImagen = false;
        int valor1 = 0;
        bool segundaImagen = false;
        int valor2 = 0;
   
        Image friends = Resources.friends;
        Image theCrown = Resources.TheCrown;
        Image dark = Resources.dark;
        Image gilmoregirls = Resources.gilmoregirls;
        Image anatomiagrey = Resources.anatomiagrey;
        Image codigolyoko = Resources.codigolyoko;
        Image hannahmontana = Resources.hannahmontana;
        Image you = Resources.you;
        Image interrogante = Resources.interrogante;

        int cont = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox1.Image = friends;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 1;
                }else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 1)
                    {
                        segundaImagen = true;
                        valor2 = 1;
                        compararImagenes(imagenes[valor1-1], imagenes[valor2-1]);
                    }
                }
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
            resetearImagenes();
            if (comenzar)
            {
                pictureBox2.Image = theCrown;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 2;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 2)
                    {
                        segundaImagen = true;
                        valor2 = 2;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar) {
                pictureBox3.Image = dark;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 3;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 3)
                    {
                        segundaImagen = true;
                        valor2 = 3;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox4.Image = gilmoregirls;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 4;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 4)
                    {
                        segundaImagen = true;
                        valor2 = 4;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox5.Image = gilmoregirls;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 5;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 5)
                    {
                        segundaImagen = true;
                        valor2 = 5;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
               
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            resetearImagenes();
            if (comenzar)
            {
                pictureBox6.Image = friends;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 6;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 6)
                    {
                        segundaImagen = true;
                        valor2 = 6;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
               
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            resetearImagenes();
            if (comenzar)
            {
                pictureBox7.Image = dark;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 7;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 7)
                    {
                        segundaImagen = true;
                        valor2 = 7;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox8.Image = theCrown;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 8;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 8)
                    {
                        segundaImagen = true;
                        valor2 = 8;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            resetearImagenes();
            if (comenzar) {
                pictureBox9.Image = anatomiagrey;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 9;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 9)
                    {
                        segundaImagen = true;
                        valor2 = 9;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox10.Image = hannahmontana;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 10;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 10)
                    {
                        segundaImagen = true;
                        valor2 = 10;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
               
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox11.Image = codigolyoko;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 11;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 11)
                    {
                        segundaImagen = true;
                        valor2 = 11;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
               
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            resetearImagenes();
            if (comenzar)
            {
                pictureBox12.Image = you;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 12;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 12)
                    {
                        segundaImagen = true;
                        valor2 = 12;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox13.Image = codigolyoko;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 13;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 13)
                    {
                        segundaImagen = true;
                        valor2 = 13;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
              
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox14.Image = you;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 14;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 14)
                    {
                        segundaImagen = true;
                        valor2 = 14;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
                
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox15.Image = anatomiagrey;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 15;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 15)
                    {
                        segundaImagen = true;
                        valor2 = 15;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
               
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            resetearImagenes();
            if (comenzar)
            {
                pictureBox16.Image = hannahmontana;
                if (!primeraImagen)
                {
                    primeraImagen = true;
                    valor1 = 16;
                }
                else if (primeraImagen && !segundaImagen)
                {
                    if (valor1 != 16)
                    {
                        segundaImagen = true;
                        valor2 = 16;
                        compararImagenes(imagenes[valor1 - 1], imagenes[valor2 - 1]);
                    }
                }
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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imagenes.Add(pictureBox1);
            imagenes.Add(pictureBox2);
            imagenes.Add(pictureBox3);
            imagenes.Add(pictureBox4);
            imagenes.Add(pictureBox5);
            imagenes.Add(pictureBox6);
            imagenes.Add(pictureBox7);
            imagenes.Add(pictureBox8);
            imagenes.Add(pictureBox9);
            imagenes.Add(pictureBox10);
            imagenes.Add(pictureBox11);
            imagenes.Add(pictureBox12);
            imagenes.Add(pictureBox13);
            imagenes.Add(pictureBox14);
            imagenes.Add(pictureBox15);
            imagenes.Add(pictureBox16);

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                label1.Text = Idioma.idioma;
                label2.Text = Idioma.nombre;
                label3.Text = Idioma.tiempo;
                label5.Text = Idioma.titulo;

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
                label5.Text = Idioma.titulo;

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
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Falta el nombre");
                }
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
                tiempo = 60;
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
                tiempo = 40;
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
                tiempo = 25;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            tiempo--;
            label4.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                if (cont < 8)
                {
                    timer1.Enabled = false;
                    MessageBox.Show(textBox1.Text + ", " + Idioma.finalizar);
                }
      
            }
            else if (tiempo != 0) {
                if (cont == 8)
                {
                    timer1.Stop();
                    MessageBox.Show(textBox1.Text + " " + Idioma.ganar);
                }
            }

            else
            {
                label4.Text = tiempo.ToString();
            }
        }

        private void compararImagenes(PictureBox pictureBox1, PictureBox pictureBox2) {

            pictureBox1ant = pictureBox1;
            pictureBox2ant = pictureBox2;

            if (pictureBox1.Image == pictureBox2.Image)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                cont++;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
          
        }
        private void resetearImagenes()
        {
            if(valor2 != 0)
            {
                
                if (pictureBox1ant.Enabled == true)
                {
                    pictureBox1ant.Image = interrogante;
                }
                if (pictureBox2ant.Enabled == true)
                {
                    pictureBox2ant.Image = interrogante;
                }
                primeraImagen = false;
                valor1 = 0;
                segundaImagen = false;
                valor2 = 0;
            }

        }
    }
}
