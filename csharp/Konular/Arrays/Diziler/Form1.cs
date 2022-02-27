using System.Collections.Generic;
using System.Collections;
namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
         
         => Diziler

        * Prosedürel programlamada veri yapýlanmalarýný ve iþleyiþini saðladýðýmýz en önemli yapýlardýr.
        * Geliþmiþ deðiþkenler ya da kümelenmiþ deðiþkenler olarak ifade edebileceðimiz gibi diziler literatürde Array's olarak geçer.
        * Dizilere deðer eklerken ya da okurken dizinin ismi ile eriþilir.
        * Literatürde nellekte ard arda sýralý veri kümeleri olarak tanýmlanýr.
        * New keyword ü ile bellekte adreslenirler ve bu þekilde dizilerin oluþturma iþlemi gerçekleþir.
        * Dizi tanýmlarken [] köþeli parantezlerle iþaretlenmesi zorunludur ve buna indexer denir. 
        * Dizi boyutunun indexer içinde verilmesi zorunludur.
        * Koleksiyonlarda sýnýrlama söz konusu deðildir.
        * Diziler referans türlü yapýlardýr ve veriler heap de adreslenir.
        * Diziler hakkýnda bir diðer önemli husus dizilerim elemalarý 0 dan baþlar ve dizinin boyutu  -1 olacak þekilde yapýlanýr.
        * Diziler sýnýrlý yapýlardýr.
       
         */

        /*
         go to: Tavsiye edilmez. Kodu senkron yapýsýnýn tersi bir þekilde hareket etmemizi saðlayan yani kodu istediðimiz þaretleme noktasýna yönlendirme eylemi yapar.

        g1: // etketadi: => Etiket Kullanýmý

        goto g1; => g1 etiketine yönlendirme yapar.
         
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        int maas2, maas1, personelSayisi;

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
           ArrayList personeller=new ArrayList();
           ArrayList personel=new ArrayList();
            
            personel.Add("arif");
            personel.Add(5);
            personeller.Add(personel);
            foreach (var item in personeller) 
            {
                MessageBox.Show(item.ToString());
               
            }
            
            
        }

        private void txtPersonelSayisi_Leave(object sender, EventArgs e)
        {
            try
            {
                int personelSayisi = int.Parse(txtPersonelSayisi.Text);
                txtPersonelSayisi.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kontrol ederek geçerli deðerler giriniz.");
                txtPersonelSayisi.Focus();
            }

            
        }

        private void txtMaas1_Leave(object sender, EventArgs e)
        {
            try
            {
              
                 maas1 = int.Parse(txtMaas1.Text);
                txtMaas1.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kontrol ederek geçerli deðerler giriniz.");
                txtMaas1.Focus();

            }
        }

        private void txtMaas2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (maas1 < maas2)
                {
                    maas2 = int.Parse(txtMaas2.Text);
                    txtMaas2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lütfen kontrol ederek geçerli deðerler giriniz.");
                }
                    
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen kontrol ederek geçerli deðerler giriniz.");
                txtMaas2.Focus();
            }
        }
    }
}