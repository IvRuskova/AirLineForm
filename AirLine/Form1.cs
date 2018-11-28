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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            AirLineDbEntities1 db = new AirLineDbEntities1();
            if(txtuser.Text != string .Empty && txtpass.Text != string.Empty)
            {
                var user = db.Admins.Where(a=>a.UserName.Equals(txtuser.Text)).SingleOrDefault();
                if (user!=null)
                {
                    if (user.Password.Equals(txtpass.Text))
                    {
                        MessageBox.Show("Succeed Login");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User name");
                }
            }
            else
            {
                MessageBox.Show("Please fill User Name & Password!");
            }
        }
    }
}
