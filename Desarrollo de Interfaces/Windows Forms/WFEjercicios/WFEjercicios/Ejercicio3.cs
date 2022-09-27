using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFEjercicios.Properties;

namespace WFEjercicios
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }

        private void elegirCoche() {
            if (radioButton1.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Resources.FerrariNegro;
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Resources.FerrariRojo;
            }
            if (radioButton1.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Resources.FerrariAmarillo;
            }
            if (radioButton2.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Resources.MasetaratiNegro;
            }
            if (radioButton2.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Resources.MasetaratiRojo;
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Resources.MaseratiAmarillo;
            }
            if (radioButton3.Checked && radioButton4.Checked)
            {
                pictureBox1.Image = Resources.BugattiNegro;
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                pictureBox1.Image = Resources.BugattiRojo;
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                pictureBox1.Image = Resources.BugattiAmarillo;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            elegirCoche();
        }
    }
}
