using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string sinif = comboBox1.Text;
            string kiz = radioButton1.Text;
            string erkek = radioButton2.Text;

            if (
                string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(radioButton1.Text)
                )
            {
                MessageBox.Show("Boş alanları doldurmadan kayıt yapamazsınız.");
            }

            else if (!int.TryParse(textBox4.Text, out int not1) ||
                          !int.TryParse(textBox5.Text, out int not2) ||
                          !int.TryParse(textBox6.Text, out int not3)
                          )
            {
                MessageBox.Show("Lütfen sayı giriniz...");
            }

            else
            {
                int not1Orani = (not1 * 40) / 100;
                int not2Orani = (not2 * 40) / 100;
                int sozluOrani = (not3 * 20) / 100;

                int ortalama = (not1Orani + not2Orani + sozluOrani);

                textBox7.Text = ortalama.ToString();

                int satir = dataGridView1.Rows.Add();

                dataGridView1.Rows[satir].Cells[0].Value = ad;
                dataGridView1.Rows[satir].Cells[1].Value = soyad;
                dataGridView1.Rows[satir].Cells[2].Value = sinif;
                dataGridView1.Rows[satir].Cells[3].Value = ortalama;

                if (radioButton1.Checked)
                {
                    dataGridView1.Rows[satir].Cells[4].Value = kiz;
                }
                else
                {
                    dataGridView1.Rows[satir].Cells[4].Value = erkek;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Ad";
            dataGridView1.Columns[1].Name = "Soyad";
            dataGridView1.Columns[2].Name = "Sınıf";
            dataGridView1.Columns[3].Name = "Ortalama";
            dataGridView1.Columns[4].Name = "Cinsiyet";

            comboBox1.Items.Add("11-A");
            comboBox1.Items.Add("11-B");
            comboBox1.Items.Add("11-C");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
