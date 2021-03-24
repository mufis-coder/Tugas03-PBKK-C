using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            timer1.Start();
            DateTime now = DateTime.Now;
            label6.Text = now.ToLongDateString();
            label7.Text = now.ToLongTimeString();
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
            var json = "";
            double rate;
            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=2bd8f3878134e78c2615", fromM.ToUpper(), toM.ToUpper());
                string key = string.Format("{0}_{1}", fromM.ToUpper(), toM.ToUpper());

                json = new WebClient().DownloadString(url);
/*                dynamic stuff = JsonConvert.DeserializeObject(json);*/
                dynamic stuff = JObject.Parse(json);
                rate = stuff[key];
            }
            catch
            {
                rate = 0.0;
            }        
            
            return rate;
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

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
