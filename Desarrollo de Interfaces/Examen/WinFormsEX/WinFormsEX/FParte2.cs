using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsEX
{
    public partial class FParte2 : Form
    {
        public FParte2()
        {
            InitializeComponent();
        }
        BindingList<Persona> personas = new BindingList<Persona>();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void FParte2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                //Primero le indicamos donde queremos que nos diga donde esta el error y luego el mensaje que queremos poner
                errorProvider1.SetError(textBox1, "Error1");
            }

            int edad = 0;
            Boolean oktEdad = false;

            oktEdad = Int32.TryParse(textBox2.Text, out edad);

            if (oktEdad == false)
            {
                errorProvider1.SetError(textBox2, "Error2");
            }
            if (textBox1.Text != "" && oktEdad == true) {
                personas.Add(new Persona
                {
                    Nombre = textBox1.Text,
                    Edad = Int32.Parse(textBox2.Text),
                });
                dataGridView1.DataSource = personas;
                textBox1.Clear();
                textBox2.Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
