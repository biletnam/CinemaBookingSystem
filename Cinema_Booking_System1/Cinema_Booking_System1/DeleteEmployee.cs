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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeleteMemberMain m = new DeleteMemberMain(); //declaring a form
            this.Hide();
            m.ShowDialog();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Fill(this.bookingsystemDBDataSet1.Employee);//loading the table
        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = (string)cbxEmployee.SelectedValue;//putting the id chosen into a variable

            employeeTableAdapter1.DeleteQuery(id); //deleting ta variable
            this.employeeTableAdapter1.Fill(this.bookingsystemDBDataSet1.Employee);//refreshing the table
        }
    }
}
