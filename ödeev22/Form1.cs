using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödeev22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd =new Random();
            int[] sayilar = new int[6];
            for (int i = 0; i < sayilar.Length; i++)

            {

                sayilar[i] = rnd.Next(1, 60);
            
            }

            Array.Sort(sayilar);
            textBox1.Text = sayilar[0].ToString();
            textBox2.Text = sayilar[1].ToString();
            textBox3.Text = sayilar[2].ToString();
            textBox4.Text = sayilar[3].ToString();
            textBox5.Text = sayilar[4].ToString();
            textBox6.Text = sayilar[5].ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            i++;
            int Tahminsayi = Convert.ToInt32(label1.Text);
            if (Tahminsayi< rnd)

            {

                label1.Text = "hepsini bildin ";


            }

            {

                else if 
            }
        }
    }
}
