using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10022022Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOncekiKayit.Enabled = false;
            btnSonrakiKayit.Enabled=false;
        }
        int musteriNo;
        string unvan;
        string telNo;
        string adres;
        double bakiye;
        string mail;
        //int[] musteriNo2;
        //string[] unvan2;
        //string[] telNo2;
        //string[] adres2;
        //double[] bakiye2;
        //string[] mail2;
        ArrayList musteriler = new ArrayList();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (DegerleriAl())
            {
                string musteri = musteriNo.ToString() + "\t" + unvan + "\t" + telNo + "\t" + adres + "\t" + bakiye.ToString() + "\t" + mail;
                listBox1.Items.Add(musteri);
                musteriler.Add(musteri);
                AlanlariTemizle();
            }
            
        }

        public bool DegerleriAl()
        {
            try
            {
                if (!TelefonKontrol(tbTelefon.Text))
                {
                    tbTelefon.Clear();
                    MessageBox.Show("Telefon numarası yanlış formatta!!\nİlgili alanı tekrardan doldurun!!");
                    return false;
                }
                else if(!IsValid(tbMail.Text))
                {
                    tbMail.Clear();
                    MessageBox.Show("Mail adresi formata uygun değil!!\nİlgili alanı tekrardan doldurun!!");
                    return false;
                }
                else
                {
                    musteriNo = Convert.ToInt32(tbMusteriNo.Text);
                    unvan = tbUnvan.Text;
                    telNo = tbTelefon.Text;
                    adres = tbAdres.Text;
                    mail = tbMail.Text;
                    bakiye = Convert.ToDouble(tbBakiye.Text);
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Bilgiler Hatalı ya da Boş Olamaz!!!");
                return false;
            }
            
        }

        public void AlanlariTemizle()
        {
            tbMusteriNo.Clear();
            tbUnvan.Clear();
            tbTelefon.Clear();
            tbAdres.Clear();
            tbBakiye.Clear();
            tbMail.Clear();
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        public static bool TelefonKontrol(string numara)
        {
            string regex = @"^(0(\d{3})-(\d{3})-(\d{2})-(\d{2}))$";

            if (numara != null) return Regex.IsMatch(numara, regex);
            else return false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        private void btnAranan_Click(object sender, EventArgs e)
        {
            try
            {
                var index = new List<int>();
                int sayac = 0;
                string[] sub = new string[6];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sub = (listBox1.Items[i].ToString()).Split('\t');
                    if (sub.Contains(tbAranan.Text, StringComparer.CurrentCultureIgnoreCase))
                    {
                        index.Add(i);
                        sayac++;
                    }
                }
                if (sayac != 1)
                {
                    MessageBox.Show("Lütfen başka bir değer arayınız");
                }
                else
                {
                    int y = index[0];
                    listBox1.SetSelected(y, true);
                }
            }
            catch 
            {
                MessageBox.Show("Hatalı giriş yapıldı!!");
            }
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
             DegerleriYaz();
           
        }

        private void DegerleriYaz()
        {
            try
            {
                string[] sub = new string[6];
                sub = (listBox1.SelectedItem.ToString()).Split('\t');
                tbMusteriNo.Text = sub[0];
                tbUnvan.Text = sub[1];
                tbTelefon.Text = sub[2];
                tbAdres.Text = sub[3];
                tbBakiye.Text = sub[4];
                tbMail.Text = sub[5];
            }
            catch
            {

            }
            
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            DegerleriAl();
            string musteri = musteriNo.ToString() + "\t" + unvan + "\t" + telNo + "\t" + adres + "\t" + bakiye.ToString() + "\t" + mail;
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, musteri);

        }

        private void btnOncekiKayit_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex -= 1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DegerleriYaz();
            int index = listBox1.SelectedIndex;
            if (index == 0)
            {
                btnSonrakiKayit.Enabled = true;
                btnOncekiKayit.Enabled = false;
            }
            else if(index > 0 && index != listBox1.Items.Count - 1)
            {
                btnOncekiKayit.Enabled = true;
                btnSonrakiKayit.Enabled = true;
            }
            else if(index == listBox1.Items.Count-1)
            {
                btnSonrakiKayit.Enabled = false;
            }
        }

        private void btnSonrakiKayit_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex += 1;
        }
    }
}
