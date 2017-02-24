using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema_Booking_System1
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            ticketForm t = new ticketForm(); //showing ticket form 
            this.Hide();
            t.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Exit aplication
            Application.Exit();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            moviesForm mov = new moviesForm(); //Showing movies
            this.Hide();
            mov.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            EmployeeLogin log = new EmployeeLogin(); //Showing employee login
            this.Hide();
            log.ShowDialog();
        }
    }
}
