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
    public partial class DeleteMemberMain : Form
    {
        public DeleteMemberMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            DelCust del = new DelCust();
            this.Hide();
            del.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            DeleteEmployee delEmp = new DeleteEmployee();
            this.Hide();
            delEmp.ShowDialog();
        }
    }
}
