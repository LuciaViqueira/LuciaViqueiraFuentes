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
    public partial class Ejercicio9b : Form
    {
        public Ejercicio9b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (tecla < 'A' || tecla > 'Z') {
                if (tecla != 'Ñ') {
                    e.Handled = true;
                }
                if (tecla == Convert.ToChar(Keys.Back)) {
                    e.Handled = false;
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            int telefono;
            if (!Int32.TryParse(textBox2.Text, out telefono)){
                MessageBox.Show("El telefono debe ser un valor numerico",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //Cuidado con esto
                e.Cancel = true;
            }

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            int arrobasComprobar = 0;
            foreach (char c in textBox3.Text)
            {
                if (c == '@')
                {
                    arrobasComprobar++;
                }
            }
            if (arrobasComprobar == 1)
            {

            }
            else
            {
                errorProvider1.SetError(textBox3, "Error3");
            }
        }
    }
}
