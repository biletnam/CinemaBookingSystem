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
    public partial class Register : Form
    {
        private List<Human> humans;
  

        public Register()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*'; //encrypting the password box
            txtPass2.PasswordChar = '*';

            humans = new List<Human>(); //initialising a new list (for polymorphism)
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            EmployeeLogin log = new EmployeeLogin(); //to log out
            this.Hide();
            log.ShowDialog();
        }

        private void cbxHumanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxHumanType.SelectedItem.ToString() == "customer") //if the user select customer from the combo box
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            if (cbxHumanType.SelectedItem.ToString() == "employee") //if the user select employee from the combo box
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter1.Fill(this.bookingsystemDBDataSet1.Customer);//loading table cunstomer
            this.employeeTableAdapter.Fill(this.bookingsystemDBDataSet1.Employee);//loading table employee

            groupBox1.Enabled = false; //before choosing from the combo box, the boxes will be disables
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            cbxTown.DataSource = Enum.GetNames(typeof(Town)); //loading data in the combo boxes (enums_
            cbxGender.DataSource = Enum.GetNames(typeof(Gender));
            cbxPosition.DataSource = Enum.GetNames(typeof(Position));
            cbxType.DataSource = Enum.GetNames(typeof(EmployeeType));
        }
        private bool ValidateCustomer() //validating customer
        {
            errorProvider.Clear();
            bool tmpValidation = true;

            if (txtName.Text == string.Empty && txtName.Enabled)
            {
                errorProvider.SetError(txtName, "Empty");
                tmpValidation = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider.SetError(txtSurname, "Empty");
                tmpValidation = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider.SetError(txtSurname, "Empty");
                tmpValidation = false;
            }
            if (txtEmail.Text == string.Empty && txtEmail.Enabled)
            {
                errorProvider.SetError(txtEmail, "Empty");
                tmpValidation = false;
            }
            if (txtTel.Text == string.Empty && txtTel.Enabled)
            {
                errorProvider.SetError(txtTel, "Empty");
                tmpValidation = false;
            }
            if (txtMob.Text == string.Empty && txtMob.Enabled)
            {
                errorProvider.SetError(txtMob, "Empty");
                tmpValidation = false;
            }

            if (txtId.Text == string.Empty && txtId.Enabled)
            {
                errorProvider.SetError(txtId, "Empty");
                tmpValidation = false;
            }
            if (txtAddress.Text == string.Empty && txtAddress.Enabled)
            {
                errorProvider.SetError(txtAddress, "Empty");
                tmpValidation = false;
            }
            if (cbxTown.SelectedItem == null && cbxTown.Enabled)
            {
                errorProvider.SetError(cbxTown, "Required");
                tmpValidation = false;
            }
            if (cbxGender.SelectedItem == null && cbxGender.Enabled)
            {
                errorProvider.SetError(cbxGender, "Required");
                tmpValidation = false;
            }
         

            return tmpValidation;
        }

        private bool ValidateEmployee() //validating employee
        {
            errorProvider.Clear();
            bool tmpValidation = true;

            if (txtName.Text == string.Empty && txtName.Enabled)
            {
                errorProvider.SetError(txtName, "Empty");
                tmpValidation = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider.SetError(txtSurname, "Empty");
                tmpValidation = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider.SetError(txtSurname, "Empty");
                tmpValidation = false;
            }
            if (txtTel.Text == string.Empty && txtTel.Enabled)
            {
                errorProvider.SetError(txtTel, "Empty");
                tmpValidation = false;
            }
            if (txtMob.Text == string.Empty && txtMob.Enabled)
            {
                errorProvider.SetError(txtMob, "Empty");
                tmpValidation = false;
            }
         
            if (txtId.Text == string.Empty && txtId.Enabled)
            {
                errorProvider.SetError(txtId, "Empty");
                tmpValidation = false;
            }
            if (txtAddress.Text == string.Empty && txtAddress.Enabled)
            {
                errorProvider.SetError(txtAddress, "Empty");
                tmpValidation = false;
            }
            if (cbxTown.SelectedItem == null && cbxTown.Enabled)
            {
                errorProvider.SetError(cbxTown, "Required");
                tmpValidation = false;
            }
            if (cbxGender.SelectedItem == null && cbxGender.Enabled)
            {
                errorProvider.SetError(cbxGender, "Required");
                tmpValidation = false;
            }
            if (cbxPosition.SelectedItem == null && cbxPosition.Enabled)
            {
                errorProvider.SetError(cbxPosition, "Required");
                tmpValidation = false;
            }
            if (cbxType.SelectedItem == null && cbxType.Enabled)
            {
                errorProvider.SetError(cbxType, "Required");
                tmpValidation = false;
            }
            if (txtUsername.Text == string.Empty && txtUsername.Enabled)
            {
                errorProvider.SetError(txtUsername, "Empty");
                tmpValidation = false;
            }
            if (txtPass.Text == string.Empty && txtPass.Enabled)
            {
                errorProvider.SetError(txtPass, "Empty");
                tmpValidation = false;
            }
            if (txtPass2.Text == string.Empty && txtPass2.Enabled)
            {
                errorProvider.SetError(txtPass2, "Empty");
                tmpValidation = false;
            }
            if (txtPass2.Text != txtPass.Text)
            {
                errorProvider.SetError(txtPass, "Passwords Dont Match");
                tmpValidation = false;
            }
            return tmpValidation;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int mobileNumber;
            int telNumber;
            if (cbxHumanType.SelectedItem.ToString() == "employee" && ValidateEmployee() && int.TryParse(txtMob.Text, out mobileNumber) && int.TryParse(txtTel.Text, out telNumber)) //checking that you enter numbers in text boxes of mobile and telephone and storing the numbers in variables (validation)
            {
                humans.Add(new Employee((Position)Enum.Parse(typeof(Position),cbxPosition.SelectedItem.ToString()),(EmployeeType)Enum.Parse(typeof(EmployeeType),cbxType.SelectedItem.ToString()),
                    txtPass.Text,txtUsername.Text,txtName.Text,txtSurname.Text,txtAddress.Text,txtId.Text,(Town)Enum.Parse(typeof(Town), cbxTown.SelectedItem.ToString()),(Gender)Enum.Parse(typeof(Gender), cbxGender.SelectedItem.ToString()),
                    mobileNumber,telNumber)); //inserting a new employee in the list

                employeeTableAdapter.Insert(txtName.Text, txtSurname.Text, txtAddress.Text, txtId.Text, cbxTown.SelectedItem.ToString(), cbxGender.SelectedItem.ToString(), mobileNumber, telNumber, cbxPosition.SelectedItem.ToString(), cbxType.SelectedItem.ToString(), txtUsername.Text, txtPass.Text); //inserting the details in the table
                
                MessageBox.Show("Added A New Employee");


            }
            if (cbxHumanType.SelectedItem.ToString() == "customer" && ValidateCustomer() && int.TryParse(txtMob.Text, out mobileNumber) && int.TryParse(txtTel.Text, out telNumber))  //checking that you enter numbers in text boxes of mobile and telephone and storing the numbers in variables (validation)
            {
                humans.Add(new Customer(txtEmail.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtId.Text, (Town)Enum.Parse(typeof(Town), cbxTown.SelectedItem.ToString()), (Gender)Enum.Parse(typeof(Gender), cbxGender.SelectedItem.ToString()), mobileNumber, telNumber)); //inserting a new customer in the list
                customerTableAdapter1.InsertQuery1(txtEmail.Text, txtName.Text, txtSurname.Text, txtAddress.Text, txtId.Text, cbxTown.SelectedItem.ToString(), cbxGender.SelectedItem.ToString(), mobileNumber, telNumber);//inserting the details in the table
                MessageBox.Show("Added A New Customer");
            }



        }

        private void btnView_Click(object sender, EventArgs e)
        {
            foreach (Human p in humans) //for each human,
            {
                if (p.GetType() == typeof(Employee)) //for each employee
                {
                    Employee tmpEmp = (Employee)p; //converting the human into employee


                    MessageBox.Show(tmpEmp.GetInfo());//doing the polymorphism, showing all info of employees
                }
                if (p.GetType() == typeof(Customer)) //for each customer
                {
                    Customer tmpCust = (Customer)p; //converting the human into customer


                    MessageBox.Show(tmpCust.GetInfo()); //doing the polymorphism, showing all info of customer
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteMemberMain delt = new DeleteMemberMain(); //show delete form
            this.Hide();
            delt.ShowDialog();
        }
    }
}
