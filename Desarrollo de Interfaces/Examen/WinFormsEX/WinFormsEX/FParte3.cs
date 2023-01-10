using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEX
{
    public partial class FParte3 : Form
    {
        public FParte3()
        {
            InitializeComponent();
        }
        int cont = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.IndexOf(0);
            cont = trackBar1.Value;
            cont++;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.IndexOf(1);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.IndexOf(2);
        }
    }
}
