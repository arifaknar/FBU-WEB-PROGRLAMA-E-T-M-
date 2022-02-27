namespace Diziler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPersonelSayisi = new System.Windows.Forms.TextBox();
            this.txtMaas1 = new System.Windows.Forms.TextBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListeOlustur = new System.Windows.Forms.Button();
            this.btnYeniListe = new System.Windows.Forms.Button();
            this.cboIl = new System.Windows.Forms.ComboBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtMaas2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Sayısı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maaş Aralığı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sicil No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad Soyad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "İl: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "En Düşük Maaş:";
            // 
            // txtPersonelSayisi
            // 
            this.txtPersonelSayisi.Location = new System.Drawing.Point(151, 35);
            this.txtPersonelSayisi.Name = "txtPersonelSayisi";
            this.txtPersonelSayisi.Size = new System.Drawing.Size(100, 23);
            this.txtPersonelSayisi.TabIndex = 7;
            this.txtPersonelSayisi.Leave += new System.EventHandler(this.txtPersonelSayisi_Leave);
            // 
            // txtMaas1
            // 
            this.txtMaas1.Location = new System.Drawing.Point(151, 64);
            this.txtMaas1.Name = "txtMaas1";
            this.txtMaas1.Size = new System.Drawing.Size(41, 23);
            this.txtMaas1.TabIndex = 8;
            this.txtMaas1.Leave += new System.EventHandler(this.txtMaas1_Leave);
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(102, 19);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(100, 23);
            this.txtSicilNo.TabIndex = 9;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(102, 44);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 10;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(102, 68);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 23);
            this.txtMaas.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "En Düşük Maaş:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListeOlustur);
            this.groupBox1.Controls.Add(this.btnYeniListe);
            this.groupBox1.Controls.Add(this.cboIl);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtSicilNo);
            this.groupBox1.Location = new System.Drawing.Point(55, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 205);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnListeOlustur
            // 
            this.btnListeOlustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListeOlustur.ForeColor = System.Drawing.Color.Crimson;
            this.btnListeOlustur.Location = new System.Drawing.Point(6, 176);
            this.btnListeOlustur.Name = "btnListeOlustur";
            this.btnListeOlustur.Size = new System.Drawing.Size(196, 23);
            this.btnListeOlustur.TabIndex = 16;
            this.btnListeOlustur.Text = "Liste Oluştur";
            this.btnListeOlustur.UseVisualStyleBackColor = true;
            // 
            // btnYeniListe
            // 
            this.btnYeniListe.Location = new System.Drawing.Point(102, 138);
            this.btnYeniListe.Name = "btnYeniListe";
            this.btnYeniListe.Size = new System.Drawing.Size(100, 23);
            this.btnYeniListe.TabIndex = 15;
            this.btnYeniListe.Text = "Yeni Liste";
            this.btnYeniListe.UseVisualStyleBackColor = true;
            // 
            // cboIl
            // 
            this.cboIl.FormattingEnabled = true;
            this.cboIl.Items.AddRange(new object[] {
            "Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cboIl.Location = new System.Drawing.Point(102, 97);
            this.cboIl.Name = "cboIl";
            this.cboIl.Size = new System.Drawing.Size(100, 23);
            this.cboIl.TabIndex = 14;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(6, 138);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(90, 23);
            this.btnPersonelEkle.TabIndex = 13;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(61, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 184);
            this.listBox1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Toplam Personel Sayısı";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(366, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "En Düşük Maaş";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(366, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "En Yüksek Maaş";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(366, 129);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 47);
            this.button7.TabIndex = 20;
            this.button7.Text = "Maaşı 300 TL Den Az Personeller";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtMaas2
            // 
            this.txtMaas2.Location = new System.Drawing.Point(198, 64);
            this.txtMaas2.Name = "txtMaas2";
            this.txtMaas2.Size = new System.Drawing.Size(41, 23);
            this.txtMaas2.TabIndex = 24;
            this.txtMaas2.Leave += new System.EventHandler(this.txtMaas2_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(590, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 363);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operasyonel Bilgiler";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(366, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 47);
            this.button8.TabIndex = 26;
            this.button8.Text = "Girişi Yapılan Son ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(366, 257);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(138, 47);
            this.button9.TabIndex = 27;
            this.button9.Text = "Maaşı 300 TL Den Az Personeller";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(366, 310);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 47);
            this.button10.TabIndex = 28;
            this.button10.Text = "Maaşı 300 TL Den Az Personeller";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaas2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaas1);
            this.Controls.Add(this.txtPersonelSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPersonelSayisi;
        private TextBox txtMaas1;
        private TextBox txtSicilNo;
        private TextBox txtAdSoyad;
        private TextBox txtMaas;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnListeOlustur;
        private Button btnYeniListe;
        private ComboBox cboIl;
        private Button btnPersonelEkle;
        private ListBox listBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtMaas2;
        private GroupBox groupBox2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button1;
    }
}