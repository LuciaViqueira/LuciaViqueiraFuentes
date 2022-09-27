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
    public partial class Ejercicio4 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "El lago de los cisnes") {
                wplayer.controls.stop();
                wplayer.URL = @"C:\Users\FP\Downloads\El lago de los cisnes.mp3";
                wplayer.controls.play();

            }
            if (listBox1.Text == "The climb")
            {
                wplayer.controls.stop();
                wplayer.URL = @"C:\Users\FP\Downloads\The Climb.mp3";
                wplayer.controls.play();

            }
            if (listBox1.Text == "Wake me up")
            {
                wplayer.controls.stop();
                wplayer.URL = @"C:\Users\FP\Downloads\Wake me up.mp3";
                wplayer.controls.play();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                listBox1.Items.Clear();
                listBox1.Items.Add("El lago de los cisnes");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("The climb");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Wake me up");
            }
        }

        private void Ejercicio4_FormClosed(object sender, FormClosedEventArgs e)
        {
            wplayer.controls.stop();
        }
    }
}
