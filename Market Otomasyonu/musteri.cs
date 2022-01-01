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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string tc = textBox3.Text;
            string no = textBox4.Text;
            string adres = textBox5.Text;

            if (ad == "" || soyad == "" || tc == "" || no == "" || adres == "")
            {
                MessageBox.Show("Boş Alan Olamaz");
            }
            else
            {
                listBox1.Items.Add("Müşteri Adı: " + ad + " Müşteri Soyadı: " + soyad + " Tc Kimlik: " + tc + " Telefon Numarası: " + no + " Adres: " + adres);
            }
        }
    }
}
