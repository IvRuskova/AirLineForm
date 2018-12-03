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
        AirLineDbEntities1 db;
        static int id = 0;

        public Customers(int ? Id)
        {
            InitializeComponent();
            if (Id!=null)
            {
                button1.Visible = false;
                db = new AirLineDbEntities1();
                Cust_Details customer = db.Cust_Details.Where(a => a.Id == Id).FirstOrDefault();
                id = customer.Id;
                nametxt.Text = customer.Name;
                lastnametxt.Text = customer.LastName;
                addresstxt.Text = customer.Address;
                phonenumtxt.Text = customer.PhoneNumber;
                emailtxt.Text = customer.Email;
                datebirthtxt.Value = (DateTime)customer.BirthDate;
            }
            else
            {
                button3.Visible = false;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            db = new AirLineDbEntities1();
            Cust_Details customer = db.Cust_Details.Where(a => a.Id == id).FirstOrDefault();
            customer.Name = nametxt.Text;
            customer.LastName = lastnametxt.Text;
            customer.Address = addresstxt.Text;
            customer.PhoneNumber= phonenumtxt.Text;
            customer.Email= emailtxt.Text;
            customer.BirthDate=datebirthtxt.Value;
            db.SaveChanges();
            MessageBox.Show("Record Updated");

        }
    }
}
