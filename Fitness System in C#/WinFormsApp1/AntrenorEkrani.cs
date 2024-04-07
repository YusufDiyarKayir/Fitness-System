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

namespace WinFormsApp1
{
    public partial class AntrenorEkrani : Form
    {
        public AntrenorEkrani()
        {
            InitializeComponent();
        }
        public string txt;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        int key;
        SqlConnection baglanti = new SqlConnection(@"...");
        private void uye()
        {
            da = new SqlDataAdapter("Select * From ...", baglanti);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void AntrenorEkrani_Load(object sender, EventArgs e)
        {
            uye();
            textboxAntrenorAd.ReadOnly = true;
            textboxAntrenorAd.Text = txt;
            
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxAd.Text == "" || textBoxGunluk.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxAd.Text + "','" + textBoxGunluk.Text + "','" + dateTimePicker1.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Gunluk Spor Bildirimi Başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    textBoxAd.Text = "";
                    textBoxGunluk.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void textBoxGuncelleKilo_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "... LIKE '" + textboxAntrenorAd.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
