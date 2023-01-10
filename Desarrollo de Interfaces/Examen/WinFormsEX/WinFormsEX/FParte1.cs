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
    public partial class FParte1 : Form
    {
        public FParte1()
        {
            InitializeComponent();
        }
        int cont = 0;
        private void FParte1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = cont.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                cont++;
                label1.Text = cont.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) {
                cont++;
                label1.Text = cont.ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont = Int32.Parse(label1.Text);
            
        }
    }
}
