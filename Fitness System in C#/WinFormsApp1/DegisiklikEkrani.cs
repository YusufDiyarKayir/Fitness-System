using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class DegisiklikEkrani : Form
    {
        public DegisiklikEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        internal string sss;

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici kullanici = new kullanici();
            kullanici.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDegisiklikEkrani_Click(object sender, EventArgs e)
        {
            if (textBoxAdSoyad.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxAdSoyad.Text + "','" + textBoxDegisecekler.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("BİLDİRİM BAŞARIYLA GÖNDERİLDİ.");
                    baglanti.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDegisecekler.Text = "";
            textBoxAdSoyad.Text = "";
            MessageBox.Show("Sıfırlama başarıyla gerçekleşti!");
        }

        private void DegisiklikEkrani_Load(object sender, EventArgs e)
        {
            textBoxAdSoyad.ReadOnly = true;
            textBoxAdSoyad.Text = sss;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
