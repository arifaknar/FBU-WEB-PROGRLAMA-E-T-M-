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

        * Prosed�rel programlamada veri yap�lanmalar�n� ve i�leyi�ini sa�lad���m�z en �nemli yap�lard�r.
        * Geli�mi� de�i�kenler ya da k�melenmi� de�i�kenler olarak ifade edebilece�imiz gibi diziler literat�rde Array's olarak ge�er.
        * Dizilere de�er eklerken ya da okurken dizinin ismi ile eri�ilir.
        * Literat�rde nellekte ard arda s�ral� veri k�meleri olarak tan�mlan�r.
        * New keyword � ile bellekte adreslenirler ve bu �ekilde dizilerin olu�turma i�lemi ger�ekle�ir.
        * Dizi tan�mlarken [] k��eli parantezlerle i�aretlenmesi zorunludur ve buna indexer denir. 
        * Dizi boyutunun indexer i�inde verilmesi zorunludur.
        * Koleksiyonlarda s�n�rlama s�z konusu de�ildir.
        * Diziler referans t�rl� yap�lard�r ve veriler heap de adreslenir.
        * Diziler hakk�nda bir di�er �nemli husus dizilerim elemalar� 0 dan ba�lar ve dizinin boyutu  -1 olacak �ekilde yap�lan�r.
        * Diziler s�n�rl� yap�lard�r.
       
         */

        /*
         go to: Tavsiye edilmez. Kodu senkron yap�s�n�n tersi bir �ekilde hareket etmemizi sa�layan yani kodu istedi�imiz �aretleme noktas�na y�nlendirme eylemi yapar.

        g1: // etketadi: => Etiket Kullan�m�

        goto g1; => g1 etiketine y�nlendirme yapar.
         
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

                MessageBox.Show("L�tfen kontrol ederek ge�erli de�erler giriniz.");
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

                MessageBox.Show("L�tfen kontrol ederek ge�erli de�erler giriniz.");
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
                    MessageBox.Show("L�tfen kontrol ederek ge�erli de�erler giriniz.");
                }
                    
            }
            catch (Exception)
            {

                MessageBox.Show("L�tfen kontrol ederek ge�erli de�erler giriniz.");
                txtMaas2.Focus();
            }
        }
    }
}