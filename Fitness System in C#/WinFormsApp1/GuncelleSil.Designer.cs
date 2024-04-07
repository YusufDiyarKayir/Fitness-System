namespace WinFormsApp1
{
    partial class GuncelleSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuncelleSil));
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.comboBoxGuncellePaket = new System.Windows.Forms.ComboBox();
            this.comboBoxGuncelleSaat = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxGuncelleTutar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGuncelleBoy = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleKilo = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleAmaci = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleHastalik = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleYas = new System.Windows.Forms.TextBox();
            this.textBoxGuncelleIsım = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxKan = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAntrenor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Black;
            this.buttonSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSil.ForeColor = System.Drawing.Color.White;
            this.buttonSil.Location = new System.Drawing.Point(441, 541);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(168, 42);
            this.buttonSil.TabIndex = 85;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonGeriDon_Click);
            this.buttonSil.MouseEnter += new System.EventHandler(this.buttonSil_MouseEnter);
            this.buttonSil.MouseLeave += new System.EventHandler(this.buttonSil_MouseLeave);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(267, 541);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(168, 42);
            this.buttonReset.TabIndex = 84;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.MouseEnter += new System.EventHandler(this.buttonReset_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.buttonReset_MouseLeave);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Black;
            this.buttonKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.Location = new System.Drawing.Point(93, 541);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(168, 42);
            this.buttonKaydet.TabIndex = 82;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            this.buttonKaydet.MouseEnter += new System.EventHandler(this.buttonKaydet_MouseEnter);
            this.buttonKaydet.MouseLeave += new System.EventHandler(this.buttonKaydet_MouseLeave);
            // 
            // comboBoxGuncellePaket
            // 
            this.comboBoxGuncellePaket.FormattingEnabled = true;
            this.comboBoxGuncellePaket.Items.AddRange(new object[] {
            "BRONZ PAKET",
            "SİLVER PAKET",
            "GOLD PAKET",
            "DİAMOND PAKET"});
            this.comboBoxGuncellePaket.Location = new System.Drawing.Point(185, 417);
            this.comboBoxGuncellePaket.Name = "comboBoxGuncellePaket";
            this.comboBoxGuncellePaket.Size = new System.Drawing.Size(145, 28);
            this.comboBoxGuncellePaket.TabIndex = 81;
            // 
            // comboBoxGuncelleSaat
            // 
            this.comboBoxGuncelleSaat.FormattingEnabled = true;
            this.comboBoxGuncelleSaat.Items.AddRange(new object[] {
            "08.00-10.00",
            "10.00-12.00",
            "12.00-14.00",
            "14.00-16.00",
            "16.00-18.00",
            "18.00-20.00"});
            this.comboBoxGuncelleSaat.Location = new System.Drawing.Point(359, 417);
            this.comboBoxGuncelleSaat.Name = "comboBoxGuncelleSaat";
            this.comboBoxGuncelleSaat.Size = new System.Drawing.Size(145, 28);
            this.comboBoxGuncelleSaat.TabIndex = 80;
            this.comboBoxGuncelleSaat.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuncelleSaat_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(359, 379);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 28);
            this.label18.TabIndex = 77;
            this.label18.Text = "GELDİĞİ SAATLER";
            // 
            // textBoxGuncelleTutar
            // 
            this.textBoxGuncelleTutar.Location = new System.Drawing.Point(185, 310);
            this.textBoxGuncelleTutar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleTutar.Name = "textBoxGuncelleTutar";
            this.textBoxGuncelleTutar.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleTutar.TabIndex = 76;
            this.textBoxGuncelleTutar.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(11, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 74;
            this.label11.Text = "İSİM SOYİSİM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(359, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 72;
            this.label7.Text = "KİLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(185, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "YAŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(185, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 70;
            this.label5.Text = "TUTAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(533, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "HASTALIK DURUMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(359, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 67;
            this.label2.Text = "ANTRENÖR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(533, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 66;
            this.label1.Text = "AMACI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 28);
            this.label8.TabIndex = 62;
            this.label8.Text = "BOY";
            // 
            // textBoxGuncelleBoy
            // 
            this.textBoxGuncelleBoy.Location = new System.Drawing.Point(11, 310);
            this.textBoxGuncelleBoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleBoy.Name = "textBoxGuncelleBoy";
            this.textBoxGuncelleBoy.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleBoy.TabIndex = 60;
            // 
            // textBoxGuncelleKilo
            // 
            this.textBoxGuncelleKilo.Location = new System.Drawing.Point(359, 206);
            this.textBoxGuncelleKilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleKilo.Name = "textBoxGuncelleKilo";
            this.textBoxGuncelleKilo.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleKilo.TabIndex = 59;
            // 
            // textBoxGuncelleAmaci
            // 
            this.textBoxGuncelleAmaci.Location = new System.Drawing.Point(533, 206);
            this.textBoxGuncelleAmaci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleAmaci.Name = "textBoxGuncelleAmaci";
            this.textBoxGuncelleAmaci.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleAmaci.TabIndex = 58;
            // 
            // textBoxGuncelleHastalik
            // 
            this.textBoxGuncelleHastalik.Location = new System.Drawing.Point(533, 310);
            this.textBoxGuncelleHastalik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleHastalik.Name = "textBoxGuncelleHastalik";
            this.textBoxGuncelleHastalik.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleHastalik.TabIndex = 57;
            // 
            // textBoxGuncelleYas
            // 
            this.textBoxGuncelleYas.Location = new System.Drawing.Point(185, 206);
            this.textBoxGuncelleYas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleYas.Name = "textBoxGuncelleYas";
            this.textBoxGuncelleYas.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleYas.TabIndex = 56;
            // 
            // textBoxGuncelleIsım
            // 
            this.textBoxGuncelleIsım.Location = new System.Drawing.Point(11, 206);
            this.textBoxGuncelleIsım.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGuncelleIsım.Name = "textBoxGuncelleIsım";
            this.textBoxGuncelleIsım.Size = new System.Drawing.Size(145, 27);
            this.textBoxGuncelleIsım.TabIndex = 55;
            this.textBoxGuncelleIsım.TextChanged += new System.EventHandler(this.textBoxGuncelleIsım_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(711, 20);
            this.label12.TabIndex = 88;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(711, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 586);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(711, 20);
            this.label14.TabIndex = 90;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 511);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(711, 20);
            this.label16.TabIndex = 91;
            this.label16.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(711, 20);
            this.label17.TabIndex = 92;
            this.label17.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Display", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(534, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(395, 63);
            this.label20.TabIndex = 94;
            this.label20.Text = "GÜNCELLE VE SİL ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(780, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(487, 31);
            this.label21.TabIndex = 95;
            this.label21.Text = "Silinecek veya Güncellenecek Üyeye Tıklayın";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 52);
            this.button1.TabIndex = 96;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(1262, 12);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(68, 51);
            this.button3.TabIndex = 114;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxKan
            // 
            this.textBoxKan.Location = new System.Drawing.Point(11, 418);
            this.textBoxKan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKan.Name = "textBoxKan";
            this.textBoxKan.Size = new System.Drawing.Size(145, 27);
            this.textBoxKan.TabIndex = 115;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(185, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 28);
            this.label15.TabIndex = 75;
            this.label15.Text = "ÜYELİK PAKETİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 28);
            this.label9.TabIndex = 116;
            this.label9.Text = "KAN GRUBU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(740, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(563, 566);
            this.dataGridView1.TabIndex = 119;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN",
            "DİĞER"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(533, 417);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(145, 28);
            this.comboBoxCinsiyet.TabIndex = 120;
            this.comboBoxCinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBoxCinsiyet_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(533, 379);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 28);
            this.label19.TabIndex = 121;
            this.label19.Text = "CİNSİYETİ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(909, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 125;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(712, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 558);
            this.label10.TabIndex = 126;
            this.label10.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n\r\n";
            // 
            // textBoxAntrenor
            // 
            this.textBoxAntrenor.Location = new System.Drawing.Point(359, 310);
            this.textBoxAntrenor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAntrenor.Name = "textBoxAntrenor";
            this.textBoxAntrenor.Size = new System.Drawing.Size(145, 27);
            this.textBoxAntrenor.TabIndex = 128;
            // 
            // GuncelleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1342, 750);
            this.Controls.Add(this.textBoxAntrenor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxKan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.comboBoxGuncellePaket);
            this.Controls.Add(this.comboBoxGuncelleSaat);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxGuncelleTutar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGuncelleBoy);
            this.Controls.Add(this.textBoxGuncelleKilo);
            this.Controls.Add(this.textBoxGuncelleAmaci);
            this.Controls.Add(this.textBoxGuncelleHastalik);
            this.Controls.Add(this.textBoxGuncelleYas);
            this.Controls.Add(this.textBoxGuncelleIsım);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuncelleSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAURUS";
            this.Load += new System.EventHandler(this.GuncelleSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSil;
        private Button buttonReset;
        private Button buttonKaydet;
        private ComboBox comboBoxGuncellePaket;
        private ComboBox comboBoxGuncelleSaat;
        private Label label18;
        private TextBox textBoxGuncelleTutar;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox textBoxGuncelleBoy;
        private TextBox textBoxGuncelleKilo;
        private TextBox textBoxGuncelleAmaci;
        private TextBox textBoxGuncelleHastalik;
        private TextBox textBoxGuncelleYas;
        private TextBox textBoxGuncelleIsım;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label20;
        private Label label21;
        private Button button1;
        private Button button3;
        private TextBox textBoxKan;
        private Label label15;
        private Label label9;
        private DataGridView dataGridView1;
        private ComboBox comboBoxCinsiyet;
        private Label label19;
        private PictureBox pictureBox4;
        private Label label10;
        private TextBox textBoxAntrenor;
    }
}