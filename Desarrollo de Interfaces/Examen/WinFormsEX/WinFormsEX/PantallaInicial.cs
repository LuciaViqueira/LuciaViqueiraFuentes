using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEX
{
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FParte1 ej1 = new FParte1();
            ej1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FParte2 ej2 = new FParte2();
            ej2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FParte3 ej3 = new FParte3();
            ej3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FParte4 ej4 = new FParte4();
            ej4.ShowDialog();   
        }
    }
}
