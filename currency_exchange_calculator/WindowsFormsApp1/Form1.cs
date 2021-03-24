using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double GetRate(string fromM, string toM)
        {          
            if (fromM == "Rupiah (IDR)")
            {
                if (toM == "Dollar (USD)")
                {
                    return 0.000069;
                }
                else if (toM == "Rupiah (IDR)")
                {
                    return 1;
                }
                else if (toM == "Yen (JPY)")
                {
                    return 0.0075;
                }
            }

            else if (fromM == "Dollar (USD)")
            {
                if (toM == "Dollar (USD)")
                {
                    return 1;
                }
                else if (toM == "Rupiah (IDR)")
                {
                    return 14444.00;
                }
                else if (toM == "Yen (JPY)")
                {
                    return 108.53;
                }
            }
            else if (fromM == "Yen (JPY)")
            {
                if (toM == "Dollar (USD)")
                {
                    return 0.0092;
                }
                else if (toM == "Rupiah (IDR)")
                {
                    return 133.15;
                }
                else if (toM == "Yen (JPY)")
                {
                    return 1;
                }
            }
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool konds1 = string.IsNullOrEmpty(textBox1.Text);
            bool konds2 = string.IsNullOrEmpty((string)comboBox1.SelectedItem);
            bool konds3 = string.IsNullOrEmpty((string)comboBox2.SelectedItem);
            if (konds1)
            {
                label5.Text = "Please fill this field!";
                label5.ForeColor = Color.Red;
            }
            if (!konds1)
            {
                label5.Text = "";
            }
            if (konds2)
            {
                PeringatanCFo.Text = "Please fill this field!";
                PeringatanCFo.ForeColor = Color.Red;
            }
            if (!konds2)
            {
                PeringatanCFo.Text = "";
            }
            if (konds3)
            {
                peringatanCTo.Text = "Please fill this field!";
                peringatanCTo.ForeColor = Color.Red;
            }
            if(!konds3)
            {
                peringatanCTo.Text = "";
            }
            if (!konds1 & !konds2 & !konds3)
            {
                string masukan = (string)comboBox1.SelectedItem;
                string keluaran = (string)comboBox2.SelectedItem;
                double curM = GetRate(masukan, keluaran);
                double hasil = double.Parse(textBox1.Text) * curM;
                HasilLabel.Text = hasil.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void peringatanCTo_Click(object sender, EventArgs e)
        {

        }

        private void PeringatanCFo_Click(object sender, EventArgs e)
        {

        }
    }
}
