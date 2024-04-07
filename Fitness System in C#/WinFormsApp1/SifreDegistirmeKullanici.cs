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
    public partial class SifreDegistirmeKullanici : Form
    {
        public SifreDegistirmeKullanici()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT *FROM Uye where Kullanici=@kullanici AND Sifre=@sifre";
            con = new SqlConnection("...");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kullanici", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBoxEskiSifre.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                SifreDegistirKullanici2 sifreDegistirKullanici2 = new SifreDegistirKullanici2();
                sifreDegistirKullanici2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Girilen Eski Şifreniz yanlıştır");
                textBoxEskiSifre.Text = "";
            }
        }
    }
}
