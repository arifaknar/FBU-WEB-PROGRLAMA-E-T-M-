namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = -2;
            switch (sayi)
            {
                case 20: 
                    MessageBox.Show("sayi 0 dan e�it veya b�y�k");
                    break;
                case var a: //var deseni
                    MessageBox.Show(a.ToString());
                    break;
               
            }
            
            int sayi1 = 2, sayi2 = 5;
            switch (sayi1,sayi2)
            {
                case (int y,2):
                    //Desen de�i�keni kullan�m� => (int y,5) ya da int(2,int y) ikindede ko�ula girdi�i i�in �al���r.
                    MessageBox.Show("sayilar ayn�");
                    break;
                case (2,int x) when ((sayi1,sayi2)==(sayi1,sayi2))://when i�inde grup kar��la�t�rma deseni
                    MessageBox.Show("Sayilar ayn� 2");
                    break;
                default:
                    MessageBox.Show("sayi 0 dan k���k");
                    break;
            }

            //C# 9.0 �li�kisel desen �rne�i
            DateTime date = new DateTime();
            string mevsim = date.Month switch 
            // degisken = switch_degiskeni switch{kosul => geri d�nd�r�len de�er ya da geri de�er d�nd�rmeyip bir i�lem yap�labilir.};
            {
                // kosul => geri d�nd�r�len de�er
                >= 3 and < 6 => "spring",
                //C# 9.0 Mant�ksal Desen �rne�i =>(Is Not,Is), AND, OR kar��la�t�rmalarda kullan�labilir.
                //Ayn� Zamanda kullan�ld��� zaman i�lem �ncelik s�ras� bu s�radad�r. => parantez i�i,(Is Not,Is), AND, OR 
                >= 6 and < 9 => "summer",
                >= 9 and < 12 => "autumn",
                12 or (>= 1 and < 3) => "winter",
                _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}.") 
                // Hi�bir case e girmezse _ => kod ile istenilen de�er d�nd�r�l�r.
            };
            MessageBox.Show(mevsim);
            if ((sayi, sayi) != (sayi1, sayi2)) //Grup kar��la�t�rmas� c# 7.3
            {
                MessageBox.Show("Oha");
            }
        }
    }
}