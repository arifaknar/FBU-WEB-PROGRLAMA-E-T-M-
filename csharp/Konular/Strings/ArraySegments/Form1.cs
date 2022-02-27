using Microsoft.Extensions.Primitives;

namespace ArraySegments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Array Segment => referans alır. Değişirse referans aldığı heap değerleride değişir.
            * Dizi maliyetlerinin azaltan struct bir yapıdır.
            * Bu yapılar ramde adreslenmiş hali hazırdaki veriyi kullanırlar. Bu da bizi ekstra maliyetden kurtarır.
            * count alır. içindeki değerlerin sayısını bilmek için.
            * 
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {2,3,4};

            //ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);
            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar,0,2); // Bu şekilde kısıtlama koyarak da data alınabilir. 0 dan itibaren 2 data için referans değerlerine erişir.

            segment1[0] = 4;
            MessageBox.Show(segment1[0] + " " + sayilar[0]);
            
        }
    }
}