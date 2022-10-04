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
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (textBox1.Text != textBox1.Text.ToUpper())
            {
                //Primero le indicamos donde queremos que nos diga donde esta el error y luego el mensaje que queremos poner
                errorProvider1.SetError(textBox1, "Error1");
            }


            int telefono = 0;
            Boolean oktlfn = false;

            oktlfn = Int32.TryParse(textBox2.Text, out telefono);

            if (oktlfn == false) {
                errorProvider1.SetError(textBox2, "Error2");
            }

            int numeroArrobas = 0;

            foreach (char c in textBox3.Text) {
                if (c == '@') {
                    numeroArrobas++;
                 }
            }
            if (numeroArrobas == 1)
            {

            }
            else {
                errorProvider1.SetError(textBox3, "Error3");
            }
            
            

        }
    }
}
