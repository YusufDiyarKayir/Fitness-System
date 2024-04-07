using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BildirimGoster : Form
    {
        public BildirimGoster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        int key;
        private void uye()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from ...", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "...");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void BildirimGoster_Load(object sender, EventArgs e)
        {
            uye();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonguncelleme_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelleSil= new GuncelleSil();
            guncelleSil.Show();
            this.Hide();
        }

        private void buttonyenikayit_Click(object sender, EventArgs e)
        {
            kayıt kayıt = new kayıt();
            kayıt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGoruntuleme uyeGoruntuleme = new UyeGoruntuleme();
            uyeGoruntuleme.Show();
            this.Hide();
        }

        private void buttonyenikayit_MouseEnter(object sender, EventArgs e)
        {
            buttonyenikayit.BackColor = Color.Silver;
        }

        private void buttonyenikayit_MouseLeave(object sender, EventArgs e)
        {
            buttonyenikayit.BackColor = Color.Black;
        }

        private void buttonguncelleme_MouseEnter(object sender, EventArgs e)
        {
            buttonguncelleme.BackColor = Color.Silver;
        }

        private void buttonguncelleme_MouseLeave(object sender, EventArgs e)
        {
            buttonguncelleme.BackColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Bildirimi Seçmelisiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from ... where BildirimSiraId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Bildirim Başarıyla Silindi!");
                    baglanti.Close();
                    uye();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
