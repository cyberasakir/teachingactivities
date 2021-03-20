using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Turgay";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Turgay";
            label7.Text = "Erdemir";
            label8.Text = "Bilgisayar Teknolojileri";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
