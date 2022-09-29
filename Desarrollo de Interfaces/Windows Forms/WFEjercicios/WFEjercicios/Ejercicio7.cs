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
    public partial class Ejercicio7 : Form
    {
        
        public Ejercicio7()
        {
            InitializeComponent();
        }
        int cont = 0;
        BindingList <Alumno> listado = new BindingList <Alumno>();
        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            listado.Add(new Alumno
            {
                Nombre = "Lucia",
                Edad = 22,
                Alta = DateTime.Parse("5/12/2018"),
                Comedor = true, 
                Turno = "Mañana"

            });

            dataGridView1.DataSource = listado;


           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listado.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            else {
                MessageBox.Show("No se puede eliminar, no hay registros");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            listado.Add(new Alumno
            {
                Nombre = textBox1.Text,
                Edad = Int32.Parse(textBox2.Text),
                Alta = dateTimePicker1.Value.Date,
                Comedor = checkBox1.Checked,
                Turno = comboBox1.Text,
            });

            dataGridView1.DataSource = listado;
        }
    }
}
