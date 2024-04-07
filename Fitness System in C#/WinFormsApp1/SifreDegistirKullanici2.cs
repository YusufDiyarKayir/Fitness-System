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
    public partial class SifreDegistirKullanici2 : Form
    {
        public SifreDegistirKullanici2()
        {
            InitializeComponent();
        }
        int key;
        SqlConnection baglanti = new SqlConnection(@"...");
       


        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE uye SET Sifre=@sifre WHERE Kullanici=@kullaniciadi",baglanti);
            cmd.Parameters.AddWithValue("@kullaniciadi",textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre",textBoxEskiSifre.Text);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
