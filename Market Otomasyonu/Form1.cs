using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kuladi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kuladi == "" || sifre == "")
            {
                MessageBox.Show("Boş yer bırakmayınız");
            }
            else if (kuladi == "kerem" && sifre == "1234")
            {
                MessageBox.Show("Oturum Açıldı");
                this.Hide();
                menu menu = new menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yalnış");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
