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
    public partial class uyegiriskayit : Form
    {
        public uyegiriskayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        int key;
        private void uyekayit()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from ...", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Uye");
            baglanti.Close();
        }
       
        SqlDataAdapter da;
        DataSet ds;
        private void uyeler()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from ...", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "...");
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxKullanici.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxKullanici.Text + "','" + textBoxSifre.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("UYE Başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    textBoxKullanici.Text = "";
                    textBoxSifre.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void uyegiriskayit_Load(object sender, EventArgs e)
        {
            uyekayit();
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxKullanici.Text = "";
            textBoxSifre.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonKaydet_MouseEnter(object sender, EventArgs e)
        {
            buttonKaydet.BackColor = Color.Silver;
        }

        private void buttonKaydet_MouseLeave(object sender, EventArgs e)
        {
            buttonKaydet.BackColor = Color.Black;
        }

        private void buttonSil_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonSil_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
