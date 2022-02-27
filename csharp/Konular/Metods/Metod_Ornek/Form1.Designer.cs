namespace Metod_Ornek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.netTutar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKdvDahilFiyat = new System.Windows.Forms.TextBox();
            this.txtKdvFiyat = new System.Windows.Forms.TextBox();
            this.cboOdemeTip = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.cboIskonto = new System.Windows.Forms.ComboBox();
            this.cboUrunAd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIskontoSinir = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunFiyat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.netTutar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtKdvDahilFiyat);
            this.groupBox1.Controls.Add(this.txtKdvFiyat);
            this.groupBox1.Controls.Add(this.cboOdemeTip);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtToplamFiyat);
            this.groupBox1.Controls.Add(this.txtUrunAdet);
            this.groupBox1.Controls.Add(this.cboIskonto);
            this.groupBox1.Controls.Add(this.cboUrunAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(225, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Ekranı";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(179, 94);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtUrunFiyat.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ürün Fiyatı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // netTutar
            // 
            this.netTutar.AutoSize = true;
            this.netTutar.Location = new System.Drawing.Point(221, 312);
            this.netTutar.Name = "netTutar";
            this.netTutar.Size = new System.Drawing.Size(13, 15);
            this.netTutar.TabIndex = 15;
            this.netTutar.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Toplam Net Ödenecek Net Tutar :";
            // 
            // txtKdvDahilFiyat
            // 
            this.txtKdvDahilFiyat.Location = new System.Drawing.Point(180, 202);
            this.txtKdvDahilFiyat.Name = "txtKdvDahilFiyat";
            this.txtKdvDahilFiyat.ReadOnly = true;
            this.txtKdvDahilFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtKdvDahilFiyat.TabIndex = 13;
            // 
            // txtKdvFiyat
            // 
            this.txtKdvFiyat.Location = new System.Drawing.Point(180, 177);
            this.txtKdvFiyat.Name = "txtKdvFiyat";
            this.txtKdvFiyat.ReadOnly = true;
            this.txtKdvFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtKdvFiyat.TabIndex = 12;
            // 
            // cboOdemeTip
            // 
            this.cboOdemeTip.FormattingEnabled = true;
            this.cboOdemeTip.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Senet",
            "Çek",
            "Diğer"});
            this.cboOdemeTip.Location = new System.Drawing.Point(180, 227);
            this.cboOdemeTip.Name = "cboOdemeTip";
            this.cboOdemeTip.Size = new System.Drawing.Size(121, 23);
            this.cboOdemeTip.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ödeme Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toplam KDV Dahil Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplam KDV Fiyat";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(180, 148);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtToplamFiyat.TabIndex = 7;
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(179, 61);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(121, 23);
            this.txtUrunAdet.TabIndex = 6;
            // 
            // cboIskonto
            // 
            this.cboIskonto.FormattingEnabled = true;
            this.cboIskonto.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10",
            "15"});
            this.cboIskonto.Location = new System.Drawing.Point(180, 123);
            this.cboIskonto.Name = "cboIskonto";
            this.cboIskonto.Size = new System.Drawing.Size(121, 23);
            this.cboIskonto.TabIndex = 5;
            // 
            // cboUrunAd
            // 
            this.cboUrunAd.FormattingEnabled = true;
            this.cboUrunAd.Items.AddRange(new object[] {
            "Bilgisayar",
            "Mouse",
            "Klavye",
            "Monitör",
            "Kulaklık"});
            this.cboUrunAd.Location = new System.Drawing.Point(179, 36);
            this.cboUrunAd.Name = "cboUrunAd";
            this.cboUrunAd.Size = new System.Drawing.Size(121, 23);
            this.cboUrunAd.TabIndex = 4;
            this.cboUrunAd.SelectedIndexChanged += new System.EventHandler(this.cboUrunAd_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "İskonto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Toplam İskonto Sınırı :";
            // 
            // txtIskontoSinir
            // 
            this.txtIskontoSinir.Location = new System.Drawing.Point(404, 386);
            this.txtIskontoSinir.Name = "txtIskontoSinir";
            this.txtIskontoSinir.ReadOnly = true;
            this.txtIskontoSinir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIskontoSinir.Size = new System.Drawing.Size(121, 23);
            this.txtIskontoSinir.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIskontoSinir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtToplamFiyat;
        private TextBox txtUrunAdet;
        private ComboBox cboIskonto;
        private ComboBox cboUrunAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label netTutar;
        private Label label8;
        private TextBox txtKdvDahilFiyat;
        private TextBox txtKdvFiyat;
        private ComboBox cboOdemeTip;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private TextBox txtIskontoSinir;
        private TextBox txtUrunFiyat;
        private Label label11;
    }
}