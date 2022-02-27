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
             Array Segment => referans al�r. De�i�irse referans ald��� heap de�erleride de�i�ir.
            * Dizi maliyetlerinin azaltan struct bir yap�d�r.
            * Bu yap�lar ramde adreslenmi� hali haz�rdaki veriyi kullan�rlar. Bu da bizi ekstra maliyetden kurtar�r.
            * count al�r. i�indeki de�erlerin say�s�n� bilmek i�in.
            * 
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {2,3,4};

            //ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);
            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar,0,2); // Bu �ekilde k�s�tlama koyarak da data al�nabilir. 0 dan itibaren 2 data i�in referans de�erlerine eri�ir.

            segment1[0] = 4;
            MessageBox.Show(segment1[0] + " " + sayilar[0]);
            
        }
    }
}