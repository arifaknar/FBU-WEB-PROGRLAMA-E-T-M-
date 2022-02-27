using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakalaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 5,hedef=3,tutulan=0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            HedefKontrol();
        }

        public void CanAzalt()
        {
            hak -= 1;

            if (hak == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;

                MessageBox.Show("Oyunu Kaybettim !!!");
            }
        }
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            //816; 489
           
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (sender.GetHashCode()!=button1.GetHashCode())
            {
                CanAzalt();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int randomWidth = random.Next(80, 700);
            int randomHeight = random.Next(70, 420);

            button1.Location = new Point(randomWidth, randomHeight);
        }

        

        public void HedefKontrol()
        {
            tutulan += 1;
            if (tutulan == hedef)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Oyunu Kazandın");

            }
        }
    }
}
