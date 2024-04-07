namespace WinFormsApp1
{
    partial class kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıt));
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxKanGrubu = new System.Windows.Forms.TextBox();
            this.textBoxBoy = new System.Windows.Forms.TextBox();
            this.textBoxKilo = new System.Windows.Forms.TextBox();
            this.textBoxAylikTutar = new System.Windows.Forms.TextBox();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAmaci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxHastalikDurumu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.comboBoxPaket = new System.Windows.Forms.ComboBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAntrenor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(238, 101);
            this.textBoxAdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(145, 27);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // textBoxKanGrubu
            // 
            this.textBoxKanGrubu.Location = new System.Drawing.Point(238, 241);
            this.textBoxKanGrubu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKanGrubu.Name = "textBoxKanGrubu";
            this.textBoxKanGrubu.Size = new System.Drawing.Size(145, 27);
            this.textBoxKanGrubu.TabIndex = 2;
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.Location = new System.Drawing.Point(238, 206);
            this.textBoxBoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.Size = new System.Drawing.Size(145, 27);
            this.textBoxBoy.TabIndex = 3;
            // 
            // textBoxKilo
            // 
            this.textBoxKilo.Location = new System.Drawing.Point(238, 171);
            this.textBoxKilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKilo.Name = "textBoxKilo";
            this.textBoxKilo.Size = new System.Drawing.Size(145, 27);
            this.textBoxKilo.TabIndex = 4;
            // 
            // textBoxAylikTutar
            // 
            this.textBoxAylikTutar.Location = new System.Drawing.Point(238, 276);
            this.textBoxAylikTutar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAylikTutar.Name = "textBoxAylikTutar";
            this.textBoxAylikTutar.Size = new System.Drawing.Size(145, 27);
            this.textBoxAylikTutar.TabIndex = 5;
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(238, 136);
            this.textBoxYas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(145, 27);
            this.textBoxYas.TabIndex = 6;
            this.textBoxYas.TextChanged += new System.EventHandler(this.textBoxYAS_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(117, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "BOY";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(86, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "KAN GRUBU";
            // 
            // textBoxAmaci
            // 
            this.textBoxAmaci.Location = new System.Drawing.Point(238, 311);
            this.textBoxAmaci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmaci.Name = "textBoxAmaci";
            this.textBoxAmaci.Size = new System.Drawing.Size(145, 27);
            this.textBoxAmaci.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "ANTRENÖR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "HASTALIK DURUMU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(389, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "AYLIK TUTAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "YAŞ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "KİLO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(86, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "İSİM SOYİSİM";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(80, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 28);
            this.label15.TabIndex = 30;
            this.label15.Text = "ÜYELİK PAKETİ";
            // 
            // textBoxHastalikDurumu
            // 
            this.textBoxHastalikDurumu.Location = new System.Drawing.Point(238, 381);
            this.textBoxHastalikDurumu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHastalikDurumu.Name = "textBoxHastalikDurumu";
            this.textBoxHastalikDurumu.Size = new System.Drawing.Size(145, 27);
            this.textBoxHastalikDurumu.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "AMACI";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(63, 486);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 28);
            this.label18.TabIndex = 45;
            this.label18.Text = "GELDİĞİ SAATLER";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(102, 452);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 28);
            this.label19.TabIndex = 46;
            this.label19.Text = "CİNSİYETİ";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN",
            "DİĞER"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(238, 449);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(145, 28);
            this.comboBoxCinsiyet.TabIndex = 47;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "08.00-10.00",
            "10.00-12.00",
            "12.00-14.00",
            "14.00-16.00",
            "16.00-18.00",
            "18.00-20.00"});
            this.comboBoxSaat.Location = new System.Drawing.Point(238, 483);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(145, 28);
            this.comboBoxSaat.TabIndex = 48;
            // 
            // comboBoxPaket
            // 
            this.comboBoxPaket.FormattingEnabled = true;
            this.comboBoxPaket.Items.AddRange(new object[] {
            "BRONZ PAKET",
            "SİLVER PAKET",
            "GOLD PAKET",
            "DİAMOND PAKET"});
            this.comboBoxPaket.Location = new System.Drawing.Point(238, 415);
            this.comboBoxPaket.Name = "comboBoxPaket";
            this.comboBoxPaket.Size = new System.Drawing.Size(145, 28);
            this.comboBoxPaket.TabIndex = 49;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Black;
            this.buttonKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.Location = new System.Drawing.Point(754, 205);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(168, 42);
            this.buttonKaydet.TabIndex = 50;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            this.buttonKaydet.MouseEnter += new System.EventHandler(this.buttonKaydet_MouseEnter);
            this.buttonKaydet.MouseLeave += new System.EventHandler(this.buttonKaydet_MouseLeave);
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackColor = System.Drawing.Color.Black;
            this.buttonGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeri.ForeColor = System.Drawing.Color.White;
            this.buttonGeri.Location = new System.Drawing.Point(754, 579);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(168, 42);
            this.buttonGeri.TabIndex = 52;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = false;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            this.buttonGeri.MouseEnter += new System.EventHandler(this.buttonGeri_MouseEnter);
            this.buttonGeri.MouseLeave += new System.EventHandler(this.buttonGeri_MouseLeave);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(754, 383);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(168, 42);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.MouseEnter += new System.EventHandler(this.buttonReset_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.buttonReset_MouseLeave);
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
            this.buttonGeriDon.Size = new System.Drawing.Size(168, 54);
            this.buttonGeriDon.TabIndex = 54;
            this.buttonGeriDon.Text = "<--";
            this.buttonGeriDon.UseVisualStyleBackColor = false;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Display", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(630, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 63);
            this.label20.TabIndex = 95;
            this.label20.Text = "KAYIT";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1262, 12);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(68, 51);
            this.button3.TabIndex = 114;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(779, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 131;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(928, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(402, 625);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 134;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.comboBoxAntrenor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxAdSoyad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxPaket);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBoxSaat);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.comboBoxCinsiyet);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBoxHastalikDurumu);
            this.groupBox1.Controls.Add(this.textBoxAylikTutar);
            this.groupBox1.Controls.Add(this.textBoxKanGrubu);
            this.groupBox1.Controls.Add(this.textBoxBoy);
            this.groupBox1.Controls.Add(this.textBoxAmaci);
            this.groupBox1.Controls.Add(this.textBoxKilo);
            this.groupBox1.Controls.Add(this.textBoxYas);
            this.groupBox1.Location = new System.Drawing.Point(320, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 613);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxAntrenor
            // 
            this.comboBoxAntrenor.FormattingEnabled = true;
            this.comboBoxAntrenor.Location = new System.Drawing.Point(238, 345);
            this.comboBoxAntrenor.Name = "comboBoxAntrenor";
            this.comboBoxAntrenor.Size = new System.Drawing.Size(145, 28);
            this.comboBoxAntrenor.TabIndex = 51;
            this.comboBoxAntrenor.SelectedIndexChanged += new System.EventHandler(this.comboBoxAntrenor_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(102, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 28);
            this.label10.TabIndex = 50;
            this.label10.Text = "KAYIT BİLGİLERİNİ GİRİNİZ";
            // 
            // kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAURUS";
            this.Load += new System.EventHandler(this.kayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxAdSoyad;
        private TextBox textBoxKanGrubu;
        private TextBox textBoxBoy;
        private TextBox textBoxKilo;
        private TextBox textBoxAylikTutar;
        private TextBox textBoxYas;
        private Label label8;
        private Label label9;
        private TextBox textBoxAmaci;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label11;
        private Label label15;
        private TextBox textBoxHastalikDurumu;
        private Label label1;
        private Label label18;
        private Label label19;
        private ComboBox comboBoxCinsiyet;
        private ComboBox comboBoxSaat;
        private ComboBox comboBoxPaket;
        private Button buttonKaydet;
        private Button buttonGeri;
        private Button buttonReset;
        private Button buttonGeriDon;
        private Label label20;
        private Button button3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private Label label10;
        private ComboBox comboBoxAntrenor;
    }
}