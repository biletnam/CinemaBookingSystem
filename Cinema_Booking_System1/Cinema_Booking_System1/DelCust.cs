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
    public partial class DelCust : Form
    {
        public DelCust()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeleteMemberMain d = new DeleteMemberMain(); //declaring a form
            this.Hide();
            d.ShowDialog();
        }

        private void DelCust_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter1.Fill(this.bookingsystemDBDataSet1.Customer); //loading the table
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = (string)cbxCust.SelectedValue; //puting the name chosen into a variable

            customerTableAdapter1.DeleteQuery(name); //deleting that variable
            this.customerTableAdapter1.Fill(this.bookingsystemDBDataSet1.Customer);//loading the table again with the new data(refresh)
        }

        private void cbxCust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // this.Validate();
           // customerBindingSource.EndEdit();
           //this.customerTableAdapter1.Update(this.bookingsystemDBDataSet1.Customer);

        }
    }
}
