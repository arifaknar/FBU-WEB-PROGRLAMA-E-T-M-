namespace ListWiewCalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void listViewDizayn()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("��renci No", 200);
            listView1.Columns.Add("��renci Ad�", 200);
            listView1.Columns.Add("��renci Notu", 200);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listViewDizayn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] bilgiler=new string[] {textBox1.Text,textBox2.Text,textBox3.Text};
            //listView1.Items.Add(new ListViewItem(bilgiler));

            //farkl� bir yol olarak

            string[] bilgiler2 = new string[] { textBox1.Text, textBox2.Text, textBox3.Text };
            var v1=new ListViewItem(bilgiler2);
            listView1.Items.Add(new ListViewItem(bilgiler2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 || listView1.SelectedItems.Count>1)
            {
                MessageBox.Show("L�tfen bir ��renci se�iniz");
            }
            else
            {
                string numara = listView1.SelectedItems[0].SubItems[0].Text;
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show(numara + " nolu ��rencinin kayd� ba�ar� ile silindi.");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("L�tfen bir ��renci se�iniz");
            }
            else
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Remove();
                }
            }
        }
    }
}