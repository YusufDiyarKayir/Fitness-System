using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonyenikayit_Click(object sender, EventArgs e)
        {
            kayıt kayıt = new kayıt();
            kayıt.Show();
            this.Hide();
        }

        private void buttonguncelleme_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelle = new GuncelleSil();
            guncelle.Show();
            this.Hide();

        }

        private void buttonodeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paketler paketler = new Paketler();
            paketler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UyeGoruntuleme uyeGoruntuleme= new UyeGoruntuleme();
            uyeGoruntuleme.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BildirimGoster bildirimGoster = new BildirimGoster();
            bildirimGoster.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YetkiliEkle yetkiliEkle = new YetkiliEkle();
            yetkiliEkle.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            uyegiriskayit uyegiriskayit=new uyegiriskayit();
            uyegiriskayit.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Antrenor antrenor = new Antrenor();
            antrenor.Show();
            this.Hide();
        }
    }
}
