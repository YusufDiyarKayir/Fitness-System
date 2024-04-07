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
    public partial class UyeGoruntuleme : Form
    {
        public UyeGoruntuleme()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlConnection baglanti = new SqlConnection(@"...");
        private void uye()
        {
            da = new SqlDataAdapter("Select * From ...", baglanti);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void UyeGoruntuleme_Load(object sender, EventArgs e)
        {
            uye();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

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

        private void textBoxAdSoyad_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "KayıtAdSoyad LIKE '" + textBoxAdSoyad.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void textBoxYas_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "KayıtAnternör  LIKE '" + textBoxYas.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
