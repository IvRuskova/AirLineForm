using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine
{
    public partial class Search_Cust : Form
    {
        public Search_Cust()
        {
            InitializeComponent();
        }

        private void Search_Cust_Load(object sender, EventArgs e)
        {
            AirLineDbEntities1 db = new AirLineDbEntities1();
            var items = db.Cust_Details.ToList();
            dataGridView2.DataSource = items;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AirLineDbEntities1 db = new AirLineDbEntities1();
            var items = db.Cust_Details.Where(a => a.Name.Equals(textBox1.Text)).ToList();
            dataGridView2.DataSource = items;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            Customers c1 = new Customers(id);
            c1.ShowDialog();
        }
    }
}
