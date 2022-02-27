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
                    MessageBox.Show("sayi 0 dan eþit veya büyük");
                    break;
                case var a: //var deseni
                    MessageBox.Show(a.ToString());
                    break;
               
            }
            
            int sayi1 = 2, sayi2 = 5;
            switch (sayi1,sayi2)
            {
                case (int y,2):
                    //Desen deðiþkeni kullanýmý => (int y,5) ya da int(2,int y) ikindede koþula girdiði için çalýþýr.
                    MessageBox.Show("sayilar ayný");
                    break;
                case (2,int x) when ((sayi1,sayi2)==(sayi1,sayi2))://when içinde grup karþýlaþtýrma deseni
                    MessageBox.Show("Sayilar ayný 2");
                    break;
                default:
                    MessageBox.Show("sayi 0 dan küçük");
                    break;
            }

            //C# 9.0 Ýliþkisel desen örneði
            DateTime date = new DateTime();
            string mevsim = date.Month switch 
            // degisken = switch_degiskeni switch{kosul => geri döndürülen deðer ya da geri deðer döndürmeyip bir iþlem yapýlabilir.};
            {
                // kosul => geri döndürülen deðer
                >= 3 and < 6 => "spring",
                //C# 9.0 Mantýksal Desen Örneði =>(Is Not,Is), AND, OR karþýlaþtýrmalarda kullanýlabilir.
                //Ayný Zamanda kullanýldýðý zaman iþlem öncelik sýrasý bu sýradadýr. => parantez içi,(Is Not,Is), AND, OR 
                >= 6 and < 9 => "summer",
                >= 9 and < 12 => "autumn",
                12 or (>= 1 and < 3) => "winter",
                _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}.") 
                // Hiçbir case e girmezse _ => kod ile istenilen deðer döndürülür.
            };
            MessageBox.Show(mevsim);
            if ((sayi, sayi) != (sayi1, sayi2)) //Grup karþýlaþtýrmasý c# 7.3
            {
                MessageBox.Show("Oha");
            }
        }
    }
}