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

    }
}
