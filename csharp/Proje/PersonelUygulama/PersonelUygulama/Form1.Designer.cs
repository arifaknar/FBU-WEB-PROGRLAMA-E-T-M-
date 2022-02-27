namespace PersonelUygulama
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
            this.label8 = new System.Windows.Forms.Label();
            this.rctAdres = new System.Windows.Forms.RichTextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtIsınSoyisim = new System.Windows.Forms.TextBox();
            this.cboDepartman = new System.Windows.Forms.ComboBox();
            this.cboCinsiyet = new System.Windows.Forms.ComboBox();
            this.cboUnvan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblUyariTel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "İsim Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cinsiyet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ünvan:";
            // 
            // rctAdres
            // 
            this.rctAdres.AcceptsTab = true;
            this.rctAdres.Location = new System.Drawing.Point(147, 174);
            this.rctAdres.Name = "rctAdres";
            this.rctAdres.Size = new System.Drawing.Size(242, 58);
            this.rctAdres.TabIndex = 8;
            this.rctAdres.Text = "";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(147, 60);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(175, 23);
            this.txtTC.TabIndex = 9;
            this.txtTC.Leave += new System.EventHandler(this.txtTC_Leave);
            // 
            // txtIsınSoyisim
            // 
            this.txtIsınSoyisim.Location = new System.Drawing.Point(147, 87);
            this.txtIsınSoyisim.Name = "txtIsınSoyisim";
            this.txtIsınSoyisim.Size = new System.Drawing.Size(175, 23);
            this.txtIsınSoyisim.TabIndex = 10;
            // 
            // cboDepartman
            // 
            this.cboDepartman.FormattingEnabled = true;
            this.cboDepartman.Items.AddRange(new object[] {
            "Bilgi İşlem",
            "İnsan Kaynakları"});
            this.cboDepartman.Location = new System.Drawing.Point(147, 117);
            this.cboDepartman.Name = "cboDepartman";
            this.cboDepartman.Size = new System.Drawing.Size(175, 23);
            this.cboDepartman.TabIndex = 12;
            // 
            // cboCinsiyet
            // 
            this.cboCinsiyet.FormattingEnabled = true;
            this.cboCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cboCinsiyet.Location = new System.Drawing.Point(147, 244);
            this.cboCinsiyet.Name = "cboCinsiyet";
            this.cboCinsiyet.Size = new System.Drawing.Size(175, 23);
            this.cboCinsiyet.TabIndex = 13;
            // 
            // cboUnvan
            // 
            this.cboUnvan.FormattingEnabled = true;
            this.cboUnvan.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı"});
            this.cboUnvan.Location = new System.Drawing.Point(147, 273);
            this.cboUnvan.Name = "cboUnvan";
            this.cboUnvan.Size = new System.Drawing.Size(175, 23);
            this.cboUnvan.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Personel Ekle ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Personel Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Personel Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(450, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 244);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(147, 145);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(175, 23);
            this.txtTel.TabIndex = 19;
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // lblUyariTel
            // 
            this.lblUyariTel.AutoSize = true;
            this.lblUyariTel.BackColor = System.Drawing.Color.Red;
            this.lblUyariTel.Location = new System.Drawing.Point(37, 149);
            this.lblUyariTel.Name = "lblUyariTel";
            this.lblUyariTel.Size = new System.Drawing.Size(13, 15);
            this.lblUyariTel.TabIndex = 20;
            this.lblUyariTel.Text = "  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.lblUyariTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboUnvan);
            this.Controls.Add(this.cboCinsiyet);
            this.Controls.Add(this.cboDepartman);
            this.Controls.Add(this.txtIsınSoyisim);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.rctAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Label label8;
        private RichTextBox rctAdres;
        private TextBox txtTC;
        private TextBox txtIsınSoyisim;
        private ComboBox cboDepartman;
        private ComboBox cboCinsiyet;
        private ComboBox cboUnvan;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private MaskedTextBox txtTel;
        private Label lblUyariTel;
    }
}