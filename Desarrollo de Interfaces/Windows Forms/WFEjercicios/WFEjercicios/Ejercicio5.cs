using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEjercicios
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        Boolean boton = false;
        int cont = 0;

        private void button1_Click(object sender, EventArgs e)
        {
             label1.Show();
            
            if (boton == false)
            {
                boton = true;
                timer1.Enabled = true;

                if (cont == 0)
                {
                    label1.Text = textBox1.Text;
                    cont = Int32.Parse(textBox1.Text);
                }
                

            }
            else {
                boton = false;
                timer1.Enabled = false;
                
            }

                    
            
        

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cont--;
            label1.Text = cont.ToString();
                
            
            if (cont == 0)
            {
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

       
    }
}
