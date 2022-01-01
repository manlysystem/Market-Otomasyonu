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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu menu = new menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string adet = textBox2.Text;
            string kdv = textBox3.Text;
            string fiyat = textBox5.Text;

            if (ad == "" || adet == "" || kdv == "" || fiyat == "")
            {
                MessageBox.Show("Boş Alan Olamaz");
            }
            else
            {
                listBox1.Items.Add("Ürün Adı: " + ad + " Adet: " + adet + " KDV: " + kdv + " Satış Fiyatı: " + fiyat);
            }
        }
    }
}
