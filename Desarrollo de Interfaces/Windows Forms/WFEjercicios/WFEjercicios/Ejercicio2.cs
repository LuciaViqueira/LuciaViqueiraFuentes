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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true){
                checkBox1.Font = new Font( checkBox1.Font, FontStyle.Bold );
            }
            else
            {
                checkBox1.Font = new Font( checkBox1.Font, FontStyle.Regular );
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Font = new Font(checkBox2.Font, FontStyle.Bold);
            }
            else { 
                  checkBox2.Font = new Font( checkBox2.Font, FontStyle.Regular );          
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
