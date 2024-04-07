namespace WinFormsApp1
{
    partial class GuvenlikSoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuvenlikSoru));
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSoru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCevap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(221, 172);
            this.textBoxKullaniciAdi.Multiline = true;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(206, 33);
            this.textBoxKullaniciAdi.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(446, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 62);
            this.label2.TabIndex = 134;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Black;
            this.buttonKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKaydet.ForeColor = System.Drawing.Color.White;
            this.buttonKaydet.Location = new System.Drawing.Point(221, 426);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(206, 42);
            this.buttonKaydet.TabIndex = 133;
            this.buttonKaydet.Text = "GÖNDER";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(142, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(259, 37);
            this.label20.TabIndex = 132;
            this.label20.Text = "GÜVENLİK SORUSU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 136;
            this.label1.Text = "KULLANİCİ ADİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 37);
            this.label3.TabIndex = 137;
            this.label3.Text = "SORU SEÇ";
            // 
            // comboBoxSoru
            // 
            this.comboBoxSoru.FormattingEnabled = true;
            this.comboBoxSoru.Items.AddRange(new object[] {
            "Doğum yılınızın rakamları toplamı",
            "Kaç çocuğunuz var",
            "Aslen nerelisiniz",
            "İlkokulunuzun adı",
            "En sevdiğiniz film"});
            this.comboBoxSoru.Location = new System.Drawing.Point(221, 259);
            this.comboBoxSoru.Name = "comboBoxSoru";
            this.comboBoxSoru.Size = new System.Drawing.Size(206, 28);
            this.comboBoxSoru.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 139;
            this.label4.Text = "CEVAPLA";
            // 
            // textBoxCevap
            // 
            this.textBoxCevap.Location = new System.Drawing.Point(221, 324);
            this.textBoxCevap.Multiline = true;
            this.textBoxCevap.Name = "textBoxCevap";
            this.textBoxCevap.Size = new System.Drawing.Size(206, 33);
            this.textBoxCevap.TabIndex = 140;
            // 
            // GuvenlikSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(516, 605);
            this.Controls.Add(this.textBoxCevap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuvenlikSoru";
            this.Text = "TAURUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKullaniciAdi;
        private Label label2;
        private Button buttonKaydet;
        private Label label20;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxSoru;
        private Label label4;
        private TextBox textBoxCevap;
    }
}