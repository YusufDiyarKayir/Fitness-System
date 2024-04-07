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
    public partial class GuvenlikSoru : Form
    {
        public GuvenlikSoru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"...");
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into ... values ('" + textBoxKullaniciAdi.Text + "','" + comboBoxSoru.SelectedItem.ToString() + "','" + textBoxCevap.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Soru başarılı bir şekilde eklendi.");
                    baglanti.Close();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }
    }
}
