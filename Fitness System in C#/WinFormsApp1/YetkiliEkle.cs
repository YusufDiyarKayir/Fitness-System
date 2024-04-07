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
    public partial class YetkiliEkle : Form
    {
        public YetkiliEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection(@"...");
        int key;
        private void yetkiligoster()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from Kullanici", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Kullanici");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void YetkiliEkle_Load(object sender, EventArgs e)
        {
            yetkiligoster();
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
                    string query = "insert into kullanici values ('" + textBoxKullanici.Text + "','" + textBoxSifre.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yetkili Başarılı bir şekilde eklendi.");
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

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonSil_Click(object sender, EventArgs e)
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
                    string query = "delete from Kullanici where Id=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla Silindi!");
                    baglanti.Close();
                    yetkiligoster();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            buttonSil.BackColor = Color.Silver;
        }

        private void buttonSil_MouseLeave(object sender, EventArgs e)
        {
            buttonSil.BackColor = Color.Black;
        }
    }
}
