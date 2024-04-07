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

namespace WinFormsApp1
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        
        private void Ant()
        {
            

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void kayıt_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select *from ...";
            komut.Connection=baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxAntrenor.Items.Add(dr["AntrenorAD"]);

            }
            baglanti.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxAdSoyad.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxAdSoyad.Text + "','" + textBoxYas.Text + "','" + textBoxKilo.Text + "','" + textBoxBoy.Text + "','" + textBoxKanGrubu.Text + "','" + textBoxAylikTutar.Text + "','" + textBoxAmaci.Text + "','" + comboBoxAntrenor.Text + "','" + textBoxHastalikDurumu.Text + "','" + comboBoxPaket.SelectedItem.ToString() + "','" + comboBoxCinsiyet.SelectedItem.ToString() + "','" + comboBoxSaat.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    textBoxAdSoyad.Text = "";
                    textBoxAmaci.Text = "";
                    comboBoxAntrenor.Text = "";
                    textBoxAylikTutar.Text = "";
                    textBoxBoy.Text = "";
                    textBoxHastalikDurumu.Text = "";
                    textBoxKanGrubu.Text = "";
                    textBoxKilo.Text = "";
                    textBoxYas.Text = "";
                    comboBoxCinsiyet.Text = "";
                    comboBoxPaket.Text = "";
                    comboBoxSaat.Text = "";
                }
                catch(Exception Ex) 
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAdSoyad.Text = "";
            textBoxAmaci.Text = "";
            comboBoxAntrenor.Text = "";
            textBoxAylikTutar.Text = "";
            textBoxBoy.Text = "";
            textBoxHastalikDurumu.Text = "";
            textBoxKanGrubu.Text = "";
            textBoxKilo.Text = "";
            textBoxYas.Text = "";
            comboBoxCinsiyet.Text = "";
            comboBoxPaket.Text = "";
            comboBoxSaat.Text = "";
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa =new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        
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

        private void comboBoxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void buttonReset_MouseEnter(object sender, EventArgs e)
        {
            buttonReset.BackColor = Color.Silver;
        }

        private void buttonReset_MouseLeave(object sender, EventArgs e)
        {
            buttonReset.BackColor = Color.Black;
        }

        private void buttonGeri_MouseEnter(object sender, EventArgs e)
        {
            buttonGeri.BackColor = Color.Silver;
        }

        private void buttonGeri_MouseLeave(object sender, EventArgs e)
        {
            buttonGeri.BackColor= Color.Black;
        }

        private void comboBoxAntrenor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
