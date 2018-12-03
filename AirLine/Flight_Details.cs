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
    public partial class Flight_Details : Form
    {
        AirLineDbEntities1 db;
        public Flight_Details()
        {
            InitializeComponent();
            db = new AirLineDbEntities1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight_Info fi = new Flight_Info();
            fi.Flight_name = flightNametxt.Text;
            fi.Source = sourcetxt.Text;
            fi.Destination = destinationtxt.Text;
            fi.Departure = departuretxt.Text;
            fi.Arrival_time = arrivalTimetxt.Text;
            fi.Flight_class = flightClasstxt.Text;
            fi.Flight_Charges = Convert.ToDecimal(flightChargestxt.Text);
            fi.Seat = Convert.ToInt16(seatstxt.Text);
            db.Flight_Info.Add(fi);
            db.SaveChanges();
            MessageBox.Show("One flight details is added");

        }
    }
}
