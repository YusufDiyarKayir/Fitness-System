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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Unutma : Form
    {
        public Unutma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        SqlCommand komut = new SqlCommand();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand kmt = new SqlCommand();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.CommandText = " Select * From Guvenlik";
            komut.Connection = baglanti;
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (textBoxKullaniciAdi.Text == oku[1].ToString())
                {
                    textBoxSoru.Text = oku[2].ToString();
                }
            }
            oku.Close();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cevap cevap = new Cevap();
            cevap.tst = textBoxKullaniciAdi.Text;
            cevap.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Unutma_Load(object sender, EventArgs e)
        {

        }
    }
}
