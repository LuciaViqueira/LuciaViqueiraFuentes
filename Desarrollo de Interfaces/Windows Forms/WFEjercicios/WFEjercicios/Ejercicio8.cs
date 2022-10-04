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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            agregarBtnDinamico();
            
        }
        private void agregarBtnDinamico() { 
            Button btnDinamico = new Button();
            btnDinamico.Name = "btnDinamico";
            btnDinamico.Text = "Saludo";
            btnDinamico.Location = new System.Drawing.Point(20,100);
            btnDinamico.Size = new System.Drawing.Size(80, 30);
            btnDinamico.BackColor = System.Drawing.Color.AliceBlue;
            btnDinamico.Click += new EventHandler(hola);
            this.Controls.Add(btnDinamico);

        }
        
        private void hola(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + textBox1.Text,
                "Saludo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
    }
}
