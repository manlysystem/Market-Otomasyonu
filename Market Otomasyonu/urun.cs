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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }

        private void urun_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string urunadi = textBox1.Text;
            string urunkodu = textBox2.Text;
            string firmaadi = textBox3.Text;
            string kategori = textBox4.Text;
            string fiyat = textBox5.Text;

            if (urunadi == "" || urunkodu == "" || firmaadi == "" || kategori == "" || fiyat == "")
            {
                MessageBox.Show("Boş Alan Olamaz");
            }
            else
            {
                listBox1.Items.Add("Ürün Adı: " + urunadi + " Ürün Kodu: " + urunkodu + " Firma Adı: " + firmaadi + " Kategori: " + kategori + " Fiyat " + fiyat);
            }
        }
    }
}
