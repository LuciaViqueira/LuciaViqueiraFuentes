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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            // agregarBoton();
            agregarLabel();

            
        }
        /*
        private void agregarBoton() { 
            Button btnDinamico = new Button();
            btnDinamico.Name = "btnDinamico";
            btnDinamico.Text = "Nuevo Boton";
            btnDinamico.Location = new System.Drawing.Point(25, 25);
            btnDinamico.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(btnDinamico);

        }
        */
        private void agregarLabel()
        {
            Label lblDinamico = new Label();
            lblDinamico.Name = "lblDinamico";
            lblDinamico.Text = "Ejercicio Windows Forms";
            lblDinamico.Location = new System.Drawing.Point(25, 25);
            lblDinamico.Size = new System.Drawing.Size(200, 125);
            Font miFuente = new Font("Times New Roman", 12);
            lblDinamico.Font = miFuente;
            this.panel1.Controls.Add(lblDinamico);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1 formulario = new Ejercicio1();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio2 checkbox = new Ejercicio2();
            checkbox.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio3 coches = new Ejercicio3();
            coches.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercicio4 musica = new Ejercicio4();
            musica.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ejercicio5 timer = new Ejercicio5();
            timer.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Ejercicio6 ejercicio6 = new Ejercicio6();
            ejercicio6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ejercicio7 ejercicio7 = new Ejercicio7();
            ejercicio7.ShowDialog();
        }
    }
}
