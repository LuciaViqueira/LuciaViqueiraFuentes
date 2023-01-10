using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsEX.Idiomas;

namespace WinFormsEX
{
    public partial class FParte4 : Form
    {
        public FParte4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                checkBox1.Text = Generico.idioma1;
                checkBox2.Text = Generico.idioma2;
                button1.Text = Generico.boton;
                checkBox2.Checked = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == Generico.boton) {
               
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
               
                MessageBox.Show(Generico.saludo + " "+comboBox1.Text);
                button1.Text = Generico.boton1;
            }
            if (button1.Text == Generico.boton1) {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                
                MessageBox.Show(Generico.saludo + " "+comboBox1.Text);
                button1.Text = Generico.boton;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                checkBox1.Text = Generico.idioma1;
                checkBox2.Text = Generico.idioma2;
                button1.Text = Generico.boton;
                checkBox1.Checked = false;

            }
        }
    }
}
