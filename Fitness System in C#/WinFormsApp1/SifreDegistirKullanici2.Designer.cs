namespace WinFormsApp1
{
    partial class SifreDegistirKullanici2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirKullanici2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxEskiSifre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 135;
            this.label1.Text = "YENİ ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(560, 9);
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
            this.buttonKaydet.Location = new System.Drawing.Point(257, 403);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(206, 42);
            this.buttonKaydet.TabIndex = 133;
            this.buttonKaydet.Text = "GÖNDER";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxEskiSifre
            // 
            this.textBoxEskiSifre.Location = new System.Drawing.Point(257, 250);
            this.textBoxEskiSifre.Multiline = true;
            this.textBoxEskiSifre.Name = "textBoxEskiSifre";
            this.textBoxEskiSifre.Size = new System.Drawing.Size(206, 33);
            this.textBoxEskiSifre.TabIndex = 132;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(192, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(271, 53);
            this.label20.TabIndex = 131;
            this.label20.Text = "YENİ ŞİFRENİZ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 33);
            this.textBox1.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 137;
            this.label3.Text = "YENİ KULLANİCİ ADI";
            // 
            // SifreDegistirKullanici2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(630, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxEskiSifre);
            this.Controls.Add(this.label20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifreDegistirKullanici2";
            this.Text = "TAURUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonKaydet;
        private TextBox textBoxEskiSifre;
        private Label label20;
        private TextBox textBox1;
        private Label label3;
    }
}