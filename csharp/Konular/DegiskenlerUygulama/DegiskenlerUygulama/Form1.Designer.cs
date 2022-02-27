
namespace DegiskenlerUygulama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblNetTutar = new System.Windows.Forms.Label();
            this.lblIskonto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHesaplamalarToplamTutar = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMiktarElma = new System.Windows.Forms.TextBox();
            this.txtMiktarArmut = new System.Windows.Forms.TextBox();
            this.txtMiktarMuz = new System.Windows.Forms.TextBox();
            this.txtMiktarKiraz = new System.Windows.Forms.TextBox();
            this.txtMiktarPortakal = new System.Windows.Forms.TextBox();
            this.cboFiyatElma = new System.Windows.Forms.ComboBox();
            this.cboFiyatArmut = new System.Windows.Forms.ComboBox();
            this.cboFiyatMuz = new System.Windows.Forms.ComboBox();
            this.cboFiyatKiraz = new System.Windows.Forms.ComboBox();
            this.cboFiyatPortakal = new System.Windows.Forms.ComboBox();
            this.cboKdv = new System.Windows.Forms.ComboBox();
            this.cboIskonto = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnYeniIslem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Armut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Muz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kiraz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Portakal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMiktarPortakal);
            this.groupBox1.Controls.Add(this.txtMiktarKiraz);
            this.groupBox1.Controls.Add(this.txtMiktarMuz);
            this.groupBox1.Controls.Add(this.txtMiktarArmut);
            this.groupBox1.Controls.Add(this.txtMiktarElma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(76, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboFiyatPortakal);
            this.groupBox2.Controls.Add(this.cboFiyatKiraz);
            this.groupBox2.Controls.Add(this.cboFiyatMuz);
            this.groupBox2.Controls.Add(this.cboFiyatArmut);
            this.groupBox2.Controls.Add(this.cboFiyatElma);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(328, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Fiyatları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Elma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Portakal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Armut";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kiraz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Muz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblNetTutar);
            this.groupBox3.Controls.Add(this.lblIskonto);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(76, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 179);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlem Sonuçları";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Toplam Tutar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Kdv";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Net Tutar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "İskonto";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(102, 30);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(102, 60);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(26, 13);
            this.lblKdv.TabIndex = 5;
            this.lblKdv.Text = "Kdv";
            // 
            // lblNetTutar
            // 
            this.lblNetTutar.AutoSize = true;
            this.lblNetTutar.Location = new System.Drawing.Point(102, 125);
            this.lblNetTutar.Name = "lblNetTutar";
            this.lblNetTutar.Size = new System.Drawing.Size(52, 13);
            this.lblNetTutar.TabIndex = 7;
            this.lblNetTutar.Text = "Net Tutar";
            // 
            // lblIskonto
            // 
            this.lblIskonto.AutoSize = true;
            this.lblIskonto.Location = new System.Drawing.Point(102, 93);
            this.lblIskonto.Name = "lblIskonto";
            this.lblIskonto.Size = new System.Drawing.Size(42, 13);
            this.lblIskonto.TabIndex = 6;
            this.lblIskonto.Text = "İskonto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnYeniIslem);
            this.groupBox4.Controls.Add(this.btnHesapla);
            this.groupBox4.Controls.Add(this.lblHesaplamalarToplamTutar);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(563, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 179);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hesaplamalar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Toplam Tutar";
            // 
            // lblHesaplamalarToplamTutar
            // 
            this.lblHesaplamalarToplamTutar.AutoSize = true;
            this.lblHesaplamalarToplamTutar.Location = new System.Drawing.Point(102, 155);
            this.lblHesaplamalarToplamTutar.Name = "lblHesaplamalarToplamTutar";
            this.lblHesaplamalarToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblHesaplamalarToplamTutar.TabIndex = 5;
            this.lblHesaplamalarToplamTutar.Text = "Toplam Tutar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboIskonto);
            this.groupBox5.Controls.Add(this.cboKdv);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(563, 259);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 179);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kesintiler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "İskonto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "KDV";
            // 
            // txtMiktarElma
            // 
            this.txtMiktarElma.Location = new System.Drawing.Point(72, 27);
            this.txtMiktarElma.Name = "txtMiktarElma";
            this.txtMiktarElma.Size = new System.Drawing.Size(100, 20);
            this.txtMiktarElma.TabIndex = 9;
            // 
            // txtMiktarArmut
            // 
            this.txtMiktarArmut.Location = new System.Drawing.Point(72, 60);
            this.txtMiktarArmut.Name = "txtMiktarArmut";
            this.txtMiktarArmut.Size = new System.Drawing.Size(100, 20);
            this.txtMiktarArmut.TabIndex = 10;
            // 
            // txtMiktarMuz
            // 
            this.txtMiktarMuz.Location = new System.Drawing.Point(72, 90);
            this.txtMiktarMuz.Name = "txtMiktarMuz";
            this.txtMiktarMuz.Size = new System.Drawing.Size(100, 20);
            this.txtMiktarMuz.TabIndex = 11;
            // 
            // txtMiktarKiraz
            // 
            this.txtMiktarKiraz.Location = new System.Drawing.Point(72, 122);
            this.txtMiktarKiraz.Name = "txtMiktarKiraz";
            this.txtMiktarKiraz.Size = new System.Drawing.Size(100, 20);
            this.txtMiktarKiraz.TabIndex = 12;
            // 
            // txtMiktarPortakal
            // 
            this.txtMiktarPortakal.Location = new System.Drawing.Point(72, 152);
            this.txtMiktarPortakal.Name = "txtMiktarPortakal";
            this.txtMiktarPortakal.Size = new System.Drawing.Size(100, 20);
            this.txtMiktarPortakal.TabIndex = 13;
            // 
            // cboFiyatElma
            // 
            this.cboFiyatElma.FormattingEnabled = true;
            this.cboFiyatElma.Items.AddRange(new object[] {
            "5.50",
            "4.75",
            "3.96",
            "8.74",
            "6.45"});
            this.cboFiyatElma.Location = new System.Drawing.Point(73, 27);
            this.cboFiyatElma.Name = "cboFiyatElma";
            this.cboFiyatElma.Size = new System.Drawing.Size(121, 21);
            this.cboFiyatElma.TabIndex = 9;
            // 
            // cboFiyatArmut
            // 
            this.cboFiyatArmut.FormattingEnabled = true;
            this.cboFiyatArmut.Items.AddRange(new object[] {
            "2.25",
            "2.65",
            "3.48",
            "3.80",
            "4.50"});
            this.cboFiyatArmut.Location = new System.Drawing.Point(73, 57);
            this.cboFiyatArmut.Name = "cboFiyatArmut";
            this.cboFiyatArmut.Size = new System.Drawing.Size(121, 21);
            this.cboFiyatArmut.TabIndex = 10;
            // 
            // cboFiyatMuz
            // 
            this.cboFiyatMuz.FormattingEnabled = true;
            this.cboFiyatMuz.Items.AddRange(new object[] {
            "10.25",
            "12.45",
            "10.85",
            "9.65",
            "8.85"});
            this.cboFiyatMuz.Location = new System.Drawing.Point(73, 90);
            this.cboFiyatMuz.Name = "cboFiyatMuz";
            this.cboFiyatMuz.Size = new System.Drawing.Size(121, 21);
            this.cboFiyatMuz.TabIndex = 11;
            // 
            // cboFiyatKiraz
            // 
            this.cboFiyatKiraz.FormattingEnabled = true;
            this.cboFiyatKiraz.Items.AddRange(new object[] {
            "5.25",
            "4.75",
            "5.00",
            "6.15",
            "8.00"});
            this.cboFiyatKiraz.Location = new System.Drawing.Point(73, 122);
            this.cboFiyatKiraz.Name = "cboFiyatKiraz";
            this.cboFiyatKiraz.Size = new System.Drawing.Size(121, 21);
            this.cboFiyatKiraz.TabIndex = 12;
            // 
            // cboFiyatPortakal
            // 
            this.cboFiyatPortakal.FormattingEnabled = true;
            this.cboFiyatPortakal.Items.AddRange(new object[] {
            "4.00",
            "4.36",
            "5.25",
            "4.65",
            "5.99"});
            this.cboFiyatPortakal.Location = new System.Drawing.Point(73, 152);
            this.cboFiyatPortakal.Name = "cboFiyatPortakal";
            this.cboFiyatPortakal.Size = new System.Drawing.Size(121, 21);
            this.cboFiyatPortakal.TabIndex = 13;
            // 
            // cboKdv
            // 
            this.cboKdv.FormattingEnabled = true;
            this.cboKdv.Items.AddRange(new object[] {
            "1",
            "8",
            "18"});
            this.cboKdv.Location = new System.Drawing.Point(73, 27);
            this.cboKdv.Name = "cboKdv";
            this.cboKdv.Size = new System.Drawing.Size(121, 21);
            this.cboKdv.TabIndex = 14;
            // 
            // cboIskonto
            // 
            this.cboIskonto.FormattingEnabled = true;
            this.cboIskonto.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "30",
            "45",
            "50",
            "75"});
            this.cboIskonto.Location = new System.Drawing.Point(73, 66);
            this.cboIskonto.Name = "cboIskonto";
            this.cboIskonto.Size = new System.Drawing.Size(121, 21);
            this.cboIskonto.TabIndex = 15;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(3, 16);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 90);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnYeniIslem
            // 
            this.btnYeniIslem.Location = new System.Drawing.Point(105, 20);
            this.btnYeniIslem.Name = "btnYeniIslem";
            this.btnYeniIslem.Size = new System.Drawing.Size(75, 86);
            this.btnYeniIslem.TabIndex = 7;
            this.btnYeniIslem.Text = "Yeni İşlem";
            this.btnYeniIslem.UseVisualStyleBackColor = true;
            this.btnYeniIslem.Click += new System.EventHandler(this.btnYeniIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMiktarPortakal;
        private System.Windows.Forms.TextBox txtMiktarKiraz;
        private System.Windows.Forms.TextBox txtMiktarMuz;
        private System.Windows.Forms.TextBox txtMiktarArmut;
        private System.Windows.Forms.TextBox txtMiktarElma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFiyatPortakal;
        private System.Windows.Forms.ComboBox cboFiyatKiraz;
        private System.Windows.Forms.ComboBox cboFiyatMuz;
        private System.Windows.Forms.ComboBox cboFiyatArmut;
        private System.Windows.Forms.ComboBox cboFiyatElma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblNetTutar;
        private System.Windows.Forms.Label lblIskonto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeniIslem;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblHesaplamalarToplamTutar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboIskonto;
        private System.Windows.Forms.ComboBox cboKdv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
    }
}

