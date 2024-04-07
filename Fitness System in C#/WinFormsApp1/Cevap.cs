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

namespace WinFormsApp1
{
    public partial class Cevap : Form
    {
        public Cevap()
        {
            InitializeComponent();
        }
        public string tst;
        SqlConnection baglanti = new SqlConnection(@"...");
        SqlCommand komut = new SqlCommand();
        SqlCommand cmd;
        SqlDataReader drr;
        SqlCommand kmtt = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT *FROM ... WHERE KullaniciAdi=@kullaniciadi AND Cevap=@cevap ";
            kmtt = new SqlCommand(sorgu, baglanti);
            kmtt.Parameters.AddWithValue("@kullaniciadi", textBoxKullaniciAdi.Text);
            kmtt.Parameters.AddWithValue("@cevap", textBox1.Text);
            baglanti.Open();
            SqlDataReader drr = kmtt.ExecuteReader();
            drr = kmtt.ExecuteReader();
            if (drr.Read())
            {
                MessageBox.Show("Tebrikler bilgileriniz doğru!");
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Girilen bilgiler yanlıştır!");
                textBoxKullaniciAdi.Text = "";

            }
            drr.Close();
        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cevap_Load(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = tst;
            
        }
    }
}
