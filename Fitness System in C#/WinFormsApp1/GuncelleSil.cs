using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        SqlDataAdapter da;
        DataSet ds;

        private void uyeler()
        {
            SqlConnection baglanti = new SqlConnection(@"...");
            SqlDataAdapter da = new SqlDataAdapter("select *from ...", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kayit");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        } 
        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxGuncelleAmaci.Text = "";
            textBoxAntrenor.Text = "";
            textBoxGuncelleBoy.Text = "";
            textBoxGuncelleTutar.Text = "";
            textBoxKan.Text = "";
            textBoxGuncelleHastalik.Text = "";
            textBoxGuncelleIsım.Text = "";
            textBoxGuncelleKilo.Text = "";
            textBoxGuncelleYas.Text = "";
            comboBoxGuncelleSaat.Text = "";
            comboBoxGuncellePaket.Text = "";
            comboBoxGuncelleSaat.Text = "";
            comboBoxCinsiyet.Text = "";
            MessageBox.Show("Sıfırlama başarıyla gerçekleşmiştir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxGuncelleIsım.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxGuncelleYas.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxGuncelleKilo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxGuncelleBoy.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxKan.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxGuncelleTutar.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBoxGuncelleAmaci.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBoxAntrenor.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBoxGuncelleHastalik.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            comboBoxGuncellePaket.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            comboBoxCinsiyet.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            comboBoxGuncelleSaat.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();


        }

        private void textBoxGuncelleIsım_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (key == 0||textBoxGuncelleAmaci.Text==""||textBoxAntrenor.Text==""||textBoxGuncelleBoy.Text == "" ||textBoxGuncelleHastalik.Text == "" || textBoxGuncelleIsım.Text == "" || textBoxGuncelleKilo.Text == "" || textBoxGuncelleTutar.Text == "" || textBoxKan.Text == "" )
            {
                MessageBox.Show("EKSİK BİLGİ!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update ... set KayıtAdSoyad='" + textBoxGuncelleIsım.Text + "',KayıtYas='" + textBoxGuncelleYas.Text + "',KayıtKilo='" + textBoxGuncelleKilo.Text + "',KayıtBoy='" + textBoxGuncelleBoy.Text + "',KayıtKanGrubu='" + textBoxKan.Text + "',KayıtAylıkTutar='" + textBoxGuncelleTutar.Text + "',KayıtAmacı='" + textBoxGuncelleAmaci.Text + "',KayıtAnternör='" + textBoxAntrenor.Text + "',KayıtHastaLık='" + textBoxGuncelleHastalik.Text + "',KayıtÜyelik='" + comboBoxGuncellePaket.Text + "',KayıtCinsiyet='" + comboBoxCinsiyet.Text + "',KayıtSaat='" + comboBoxGuncelleSaat.Text + "' where KayıtId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("ÜYE VERİLERİNDEKİ DEĞİŞİKLİK BAŞARIYLA KAYDEDİLDİ!");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
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
                    string query = "delete from kayit where KayıtId=" + key + ";";
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

        
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBoxGuncelleIsım.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxGuncelleYas.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxGuncelleKilo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxGuncelleBoy.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxKan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxGuncelleTutar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxGuncelleAmaci.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxAntrenor.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxGuncelleHastalik.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBoxGuncellePaket.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBoxCinsiyet.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            comboBoxGuncelleSaat.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void comboBoxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
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

        private void buttonSil_MouseEnter(object sender, EventArgs e)
        {
            buttonSil.BackColor = Color.Silver;
        }

        private void buttonSil_MouseLeave(object sender, EventArgs e)
        {
            buttonSil.BackColor = Color.Black;
        }

        private void comboBoxGuncelleSaat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
