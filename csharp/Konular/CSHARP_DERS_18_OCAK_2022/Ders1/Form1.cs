using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders1;



namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string ad="arif",ad2="emir";
            int maas = 5000, maas1 = 6000, prim = 1000,prim2=500;

            if (ad == "arif")
            {
                if (maas == 6000)
                {
                    maas = maas + prim;
                }
                else
                {
                    maas = maas + prim2;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SAYI1 sayi1 = new SAYI1();
            MessageBox.Show(sayi1.ToString());
            

        }
    }
}
