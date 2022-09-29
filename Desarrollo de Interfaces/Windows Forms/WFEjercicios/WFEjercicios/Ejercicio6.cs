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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        int cont = 0;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value * 10;
            label1.Text = trackBar1.Value.ToString();
            label2.Text = trackBar1.Value.ToString();

            timer1.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont = Int32.Parse(label2.Text);

            if (cont > 0)
            {
                cont--;

                label2.Text = cont.ToString();
                progressBar1.Value = cont * 10;
            }
            else {
                timer1.Enabled = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
