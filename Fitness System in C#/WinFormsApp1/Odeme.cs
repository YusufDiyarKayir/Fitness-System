using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlConnection baglanti = new SqlConnection(@"...");
        int key=0;
        private void odeme()
        {

            da = new SqlDataAdapter("Select * From ...", baglanti);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = "";
            textBoxOdeme.Text = "";
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            odeme();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxAdSoyad.Text == ""|| textBoxOdeme.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxAdSoyad.Text + "','" + textBoxOdeme.Text + "','" + dateTimePicker1.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    textBoxAdSoyad.Text = "";
                    textBoxOdeme.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void comboBoxAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Ödemeyi Seçmelisiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from ... where OdemeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Odeme Başarıyla Silindi!");
                    baglanti.Close();
                    odeme();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "OdemeAdSoyad LIKE '" + textBoxArama.Text + "%'";
            dataGridView1.DataSource = dv;
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void buttonSil_MouseEnter(object sender, EventArgs e)
        {
            buttonSil.BackColor = Color.Silver;
        }

        private void buttonSil_MouseLeave(object sender, EventArgs e)
        {
            buttonSil.BackColor = Color.Black;
        }

        private void textboxTarihArama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
