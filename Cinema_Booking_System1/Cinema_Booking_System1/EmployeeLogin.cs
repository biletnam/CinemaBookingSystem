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
    public partial class EmployeeLogin : Form
    {
        private Employee employee;


        public EmployeeLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; //so that the password s not shown in the text box when typing the password

            //creating a new employee
            Position position = Position.Ticket_Seller;
            EmployeeType employeeType = EmployeeType.Full_Time;
            string password = "123";
            string user = "kevin";
            String name = "Kevin";
            String surname = "Portelli";
            String address = "3, Triq il-Bieb";
            String id = "235590M";
            Town town = Town.Bugibba;
            Gender gender = Gender.Male;
            int mobileNumber = 79080806;
            int telephoneNumber = 22345543;

            employee = new Employee(position, employeeType,password,user, name, surname, address, id, town, gender, mobileNumber, telephoneNumber); //creating the employee
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Fill(bookingsystemDBDataSet1.Employee); //loading the data ... to be continued in btnLogin_Click
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         

            if ((txtUsername.Text == employee.User && txtPassword.Text == employee.Password)) //if username and password matches to kevin and 123
            {
                mainMenu f1 = new mainMenu();
                this.Hide();
                f1.ShowDialog();
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin") //if admin logs in
            {
                Register r = new Register(); //displaying the frm register
                this.Hide();
                r.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Wrong Credentials"); //if something is wrong 
            }
        }
    }
}
