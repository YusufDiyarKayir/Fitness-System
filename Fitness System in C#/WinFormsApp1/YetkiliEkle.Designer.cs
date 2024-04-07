namespace WinFormsApp1
{
    partial class YetkiliEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliEkle));
            this.button3 = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxKullanici = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1262, 16);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(68, 51);
            this.button3.TabIndex = 116;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.BackColor = System.Drawing.Color.Black;
            this.buttonGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeriDon.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGeriDon.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGeriDon.Location = new System.Drawing.Point(12, 12);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(168, 50);
            this.buttonGeriDon.TabIndex = 115;
            this.buttonGeriDon.Text = "<--";
            this.buttonGeriDon.UseVisualStyleBackColor = false;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Display", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(436, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(478, 63);
            this.label20.TabIndex = 114;
            this.label20.Text = "YETKİLİ GİRİŞİ EKLEME";
            // 
            // textBoxKullanici
            // 
            this.textBoxKullanici.Location = new System.Drawing.Point(504, 186);
            this.textBoxKullanici.Multiline = true;
            this.textBoxKullanici.Name = "textBoxKullanici";
            this.textBoxKullanici.Size = new System.Drawing.Size(206, 33);
            this.textBoxKullanici.TabIndex = 117;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(504, 273);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(206, 33);
            this.textBoxSifre.TabIndex = 118;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(931, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(399, 513);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 120;
            this.label1.Text = "YETKİLİNİN ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 32);
            this.label2.TabIndex = 121;
            this.label2.Text = "YETKİLİNİN ŞİFRESİ";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Black;
            this.buttonKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.Location = new System.Drawing.Point(746, 187);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(168, 42);
            this.buttonKaydet.TabIndex = 122;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            this.buttonKaydet.MouseEnter += new System.EventHandler(this.buttonKaydet_MouseEnter);
            this.buttonKaydet.MouseLeave += new System.EventHandler(this.buttonKaydet_MouseLeave);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Black;
            this.buttonSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.Location = new System.Drawing.Point(746, 265);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(168, 42);
            this.buttonSil.TabIndex = 123;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            this.buttonSil.MouseEnter += new System.EventHandler(this.buttonSil_MouseEnter);
            this.buttonSil.MouseLeave += new System.EventHandler(this.buttonSil_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(920, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 131;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // YetkiliEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullanici);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAURUS";
            this.Load += new System.EventHandler(this.YetkiliEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button3;
        private Button buttonGeriDon;
        private Label label20;
        private TextBox textBoxKullanici;
        private TextBox textBoxSifre;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button buttonKaydet;
        private Button buttonSil;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}