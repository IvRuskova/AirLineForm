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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirLineDbEntities1 db = new AirLineDbEntities1();
            Cust_Details customers = new Cust_Details
            {
                Name=nametxt.Text,
                LastName=lastnametxt.Text,
                Address = addresstxt.Text,
                PhoneNumber= phonenumtxt.Text,
                Email=emailtxt.Text,
                BirthDate=datebirthtxt.Value
                
            };

            db.Cust_Details.Add(customers);
            db.SaveChanges();
            MessageBox.Show("Add one customer");
        }
    }
}
