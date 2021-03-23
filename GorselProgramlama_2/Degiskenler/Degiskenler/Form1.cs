using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje;
            string isim, soyisim;
            double ortalama;
            const double sayi=3;
            
                        
            isim = textBox1.Text;
            soyisim = textBox2.Text;

            vize = Convert.ToDouble(textBox3.Text);
            final = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);

            ortalama = (vize + final + proje) / sayi;

       

            listBox1.Items.Add(isim + " " + soyisim + "  Ortalama: " + ortalama);

            listBox1.Items.Add(isim + " " + soyisim + "  Ortalama: " + ortalama.ToString("0.00"));





        }
    }
}
