using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinFormsApp1
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        SqlCommand komut = new SqlCommand();
        public string yazi;
        public string sss;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        int key;
        private void uye()
        {
            da = new SqlDataAdapter("Select * From Gunluk", baglanti);
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "...  LIKE '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();    
            komut.CommandText = " Select * From ...";  
            komut.Connection = baglanti;
            SqlDataReader oku = komut.ExecuteReader(); 

            while (oku.Read()) 
            {
                if (textBox1.Text == oku[1].ToString()) 
                {
                    textBoxAdSoyad.Text = oku[1].ToString();
                    textBoxYas.Text= oku[2].ToString();
                    textBoxKilo.Text= oku[3].ToString();
                    textBoxBoy.Text= oku[4].ToString();
                    textBoxKanGrubu.Text= oku[5].ToString();
                    textBoxAylikTutar.Text= oku[6].ToString();
                    textBoxAmaci.Text=oku[7].ToString();
                    textBoxAntrenor.Text=oku[8].ToString();
                    textBoxHastalikDurumu.Text=oku[9].ToString();
                    comboBoxPaket.Text= oku[10].ToString();
                    comboBoxCinsiyet.Text= oku[11].ToString();
                    comboBoxSaat.Text= oku[12].ToString(); 
                    
                }
            }
            MessageBox.Show("Bilgileriniz sunulmuştur.");
            oku.Close();       
            baglanti.Close();  
        }

        private void kullanici_Load(object sender, EventArgs e)
        {
            uye();
            textBox1.ReadOnly = true;
            textBox1.Text = yazi;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DegisiklikEkrani kals = new DegisiklikEkrani();
            kals.sss = textBox1.Text;
            kals.Show();

        }

        private void buttonKaydet_MouseEnter(object sender, EventArgs e)
        {
            buttonKaydet.BackColor = Color.Silver;
        }

        private void buttonKaydet_MouseLeave(object sender, EventArgs e)
        {
            buttonKaydet.BackColor = Color.Black;
        }

        private void comboBoxPaket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreDegistirmeKullanici sifreDegistirmeKullanici = new SifreDegistirmeKullanici();
            sifreDegistirmeKullanici.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GuvenlikSoru guvenlikSoru = new GuvenlikSoru();
            guvenlikSoru.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxGunluk.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBoxGunluk.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
