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

namespace WinFormsApp1
{
    public partial class Antrenor : Form
    {
        public Antrenor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        int key;
        private void uyeler()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from ...", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "...");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBox1.Text + "','"+textBoxSifre.Text+"')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Antrenor Başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    textBox1.Text = "";
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

        private void Antrenor_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Kişiyi Seçmelisiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from AntrenorEkle where Id=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi!");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
