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
    public partial class Ticket_Reservation : Form
    {
        AirLineDbEntities1 db;
       

        public Ticket_Reservation()
        {
            InitializeComponent();
            db = new AirLineDbEntities1();
            BindSource();
            BindDestination();
        }

        private void BindDestination()
        {
            var items = db.Flight_Info.ToList();
            DestinationCombo.DataSource = items;
            DestinationCombo.DisplayMember = "Destination";
            //throw new NotImplementedException();
        }

        private void BindSource()
        {
            var items = db.Flight_Info.ToList();
            SourceCombo.DataSource = items;
            SourceCombo.DisplayMember = "Source";
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SourceCombo.Text != DestinationCombo.Text)
            {
                dataGridView1.DataSource = db.Flight_Info.Where(a => a.Source.Equals(SourceCombo.Text) && a.Destination.Equals(DestinationCombo.Text)).ToList();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(custIdtxt.Text);
            var item = db.Cust_Details.Where(a => a.Id == id).FirstOrDefault();
            custNametxt.Text = item.Name;
            lastNametxt.Text = item.LastName;
            addresstxt.Text = item.Address;
            phonetxt.Text = item.PhoneNumber;
            emailtxt.Text = item.Email;
            dateOfBirth.Value = (DateTime)item.BirthDate;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var flightid = dataGridView1.SelectedRows[0].Cells[0].Value;
            flightIdtxt.Text = flightid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(seatNotxt.Text) <= 50)
            {
                if (AvailableSeat() == true)
                {
                    Booking booking = new Booking();
                    booking.CustomerId = Convert.ToInt32(custIdtxt.Text);
                    booking.DateOfJourney = dateOfJourney.Value;
                    booking.FlightId = Convert.ToInt32(flightIdtxt.Text);
                    booking.SeatNo = Convert.ToInt32(seatNotxt.Text);
                    db.Bookings.Add(booking);
                    db.SaveChanges();
                    MessageBox.Show("Add Ticket");
                }
                else
                {
                    MessageBox.Show("Seat No is already booked");
                }
            }
            else
            {
                MessageBox.Show("Seat Number is less than 50 or equal to 50");
            }
        }

        private bool AvailableSeat()
        {
            int flightid = Convert.ToInt32(flightIdtxt.Text);
            int seatNo = Convert.ToInt32(seatNotxt.Text);
            string dateofjourney = dateOfJourney.Value.ToString("DD/MM/YYYY");
            var item = db.Bookings.Where(a => a.FlightId == flightid && a.SeatNo == seatNo).FirstOrDefault();
            if (item != null)
            {
                string existsdate = ((DateTime)item.DateOfJourney).ToString("DD/MM/YYYY");

                if (existsdate == dateofjourney)

                return false;
            else
                    return true;  
            }
            else
            {
                return true;
            }
        }
    }
}
