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
using WFEjercicios.Idiomas;

namespace WFEjercicios
{
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0) {
                
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-US");
                label2.Text = Generico.Saludo;
                button1.Text = Generico.Boton;
            }
            if (comboBox1.SelectedIndex == 1) {
               
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                label2.Text = Generico.Saludo;
                button1.Text = Generico.Boton;
            }
            comboBox1.Items.Clear();
            comboBox1.Items.Add(Generico.TextoS);
            comboBox1.Items.Add(Generico.TextoI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Saludar") {
                CultureInfo cultura = new CultureInfo("es-ES");
                Thread.CurrentThread.CurrentCulture = cultura;
                MessageBox.Show(Generico.Texto);
            }
            if (button1.Text == "Greet") {
                CultureInfo cultura = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = cultura;
                MessageBox.Show(Generico.Texto);
            }
           
        }

        private void Ejercicio10_Load(object sender, EventArgs e)
        {

        }
    }
}
