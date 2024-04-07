using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Giris : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Giris()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonsifirla_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";
            MessageBox.Show("Sýfýrlama baþarýyla gerçekleþmiþtir");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSifre.PasswordChar.ToString() == "*")
            {
                textBoxSifre.PasswordChar = char.Parse("\0");
                button1.Text = "Gizle";
            }
            else
            {
                textBoxSifre.PasswordChar = char.Parse("*");
                button1.Text = "Göster";
            }
        }

        private void checkBoxYetkili_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxYetkili.Checked)
            {
                string sorgu = "SELECT *FROM ... where kullanici=@kullanici AND Sifre=@sifre";
                con = new SqlConnection("...");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kullanici", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler bilgileriniz doðru!");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler yanlýþtýr!");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
                
            }
            if (checkBoxKullanýcý.Checked)
            {
                string sorgu = "SELECT *FROM ... where Kullanici=@kullanici AND Sifre=@sifre";
                con = new SqlConnection("...");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kullanici", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler bilgileriniz doðru!");
                    kullanici kln = new kullanici();
                    kln.yazi = textBoxKullaniciAdi.Text;
                    this.Hide();
                    kln.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler yanlýþtýr!");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
                
            }
            if (checkBoxAntrenor.Checked)
            {
                string sorgu = "SELECT *FROM ... where AntrenorAd=@kullanici AND AntrenorSifre=@sifre";
                con = new SqlConnection("...");
                cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kullanici", textBoxKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@sifre", textBoxSifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Tebrikler bilgileriniz doðru!");
                    AntrenorEkrani antrenorEkrani = new AntrenorEkrani();
                    antrenorEkrani.txt = textBoxKullaniciAdi.Text;
                    antrenorEkrani.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Girilen bilgiler yanlýþtýr!");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unutma unutma = new Unutma();
            unutma.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }

        private void buttonsifirla_MouseEnter(object sender, EventArgs e)
        {
            buttonsifirla.BackColor = Color.Red;
        }

        private void buttonsifirla_MouseLeave(object sender, EventArgs e)
        {
            buttonsifirla.BackColor = Color.Silver;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
        }

        private void checkBoxAntrenor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}