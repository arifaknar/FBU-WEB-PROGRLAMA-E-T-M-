namespace Metods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewDizayn2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewDizayn1();
        }

        private void DataGridViewDizayn2()
        {
            dataGridView1.ColumnCount = 3;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

        }

        private void DataGridViewDizayn1()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = Color.Beige;
            dataGridViewCellStyle1.Font=new Font("Verdana",10,FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            
            //Column Header Name
            dataGridView1.Columns[0].Name = "Recipe";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Main Ingredlents";
            dataGridView1.Columns[3].Name = "Rating";

            //Rows

            string[] row1 = { "Meatloaf", "Main Disk", "ground beef","**" };
            string[] row2 = { "Key Lime Pie", "Dessert", "Lime juice, evaporated milk","****" };
            string[] row3 = { "Orange-Salsa Pork Chops", "Main Disk", "Salad","***" };
            object[] rows = { row1,row2,row3};

            foreach (string[] row in rows)
            {
                dataGridView1.Rows.Add(row);
            }

        }
    }
}