using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Mail; //Written

namespace Cinema_Booking_System1
{
    public partial class ticketForm : Form
    {
        private ticket tmpTicket; //declaring variables
        private ticket tmpTicket2;
        private Seat tmpSeat;
        private Customer tmpCustomer;
        private Theatre theatreA, theatreB;
        private int theatreNoA = 1;
        private int theatreNoB = 2;
        private List<Seat> seatsA,seatsB;
        private DateTime showTimeA,showTimeB;

        public SmtpClient client = new SmtpClient(); //to send email to client
        public MailMessage msg = new MailMessage(); //to send an email

        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("2ED5mcast@gmail.com", "mcast2014"); //so that the system is able to send an email

        public ticketForm()
        {
            InitializeComponent();  
        }

        public void SendEmail(string sendTo, string sendFrom, string subject, string body)
        {
            try
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smtpCreds;
                client.EnableSsl = true;

                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress(sendFrom);

                msg.Subject = subject;
                msg.Body = body;
                msg.From = from;
                msg.To.Add(to);

                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string idNo = txtID.Text; //getting the variables
            string address = rchTxtAdress.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;

            int mobile; 
            int telephone;
            int quantAdult;
            int quantAdult2;

            tmpTicket = new ticket();//creating new tickets
            tmpTicket2 = new ticket();

            if (ValidateControls() && int.TryParse(txtMobile.Text, out mobile) && int.TryParse(txtTelephone.Text, out telephone) && int.TryParse(txtTicketAdult.Text, out quantAdult) && int.TryParse(txtTicketChild.Text, out quantAdult2)) //checking that you enter numbers in text boxes of mobile and telephone and storing the numbers in variables (validation)
                {
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), cbxGender.SelectedItem.ToString()); //coverting from string to enumeration
                    Town town = (Town)Enum.Parse(typeof(Town), cbxTown.SelectedItem.ToString()); //coverting from string to enumeration
                    tmpCustomer = new Customer(email, name, surname, address, idNo, town, gender, mobile, telephone); // creating a new customer

                    Movie m = new Movie();//creating variable for movie
                    tmpSeat = new Seat();

                    double typPrice = tmpTicket.GetPrice(TicketType.Adult);
                    double ticketPrice = tmpTicket.GenerateTicketPrice(typPrice,quantAdult);//setting price into a variable

                    double typPrice2 = tmpTicket2.GetPrice(TicketType.Child);
                    double ticketPrice2 = tmpTicket2.GenerateTicketPrice(typPrice2, quantAdult2);//setting price into a variable

                    tmpTicket = new ticket(m, theatreA, tmpCustomer, ticketPrice, tmpSeat, TicketType.Adult, quantAdult);//creating ticket
                    tmpTicket2 = new ticket(m, theatreA, tmpCustomer, ticketPrice, tmpSeat, TicketType.Child, quantAdult2);//creating ticket

                    customerTableAdapter.InsertQuery1(email, name, surname, address, idNo, town.ToString(), gender.ToString(), mobile, telephone);//insert the detals in the database
                    MessageBox.Show("A New Customer Has been added :" + tmpCustomer.GetInfo() + "\n  Your Tickets : " + tmpTicket.GetInfo() + "\n" +  tmpTicket2.GetInfo());
                    SendEmail(txtEmail.Text, "2ED5mcast@gmail.com", "Cinema", "Thanks for booking a ticket with our cinemas! Visit our site for offers that we have!"); //sending the email
                    
                     Print p = new Print(); //displaying the frm register
                     p.ShowDialog();
                    
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingsystemDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookingsystemDBDataSet.Employee); //loading data to fill table

            showTimeA = new DateTime(2014, 6, 7, 8, 45, 0, 0); //declaring date and time of the movie
            showTimeB = new DateTime(2014, 6, 7, 7, 45, 0, 0);

            theatreA = new Theatre(theatreNoA, seatsA, showTimeA); //declaring theatres
            theatreB = new Theatre(theatreNoB, seatsB, showTimeB);

            cbxGender.Items.AddRange(Enum.GetNames(typeof(Gender))); //filling the combo boxes with data(enums)
            cbxTown.Items.AddRange(Enum.GetNames(typeof(Town)));

            cbxTheatre.Items.Add(theatreA.GetInfo()); //filling the combo boxes with theatre details
            cbxTheatre.Items.Add(theatreB.GetInfo());


            this.seatTableAdapter.Fill(this.bookingsystemDBDataSet.Seat); //loading the data to fill
           
            this.customerTableAdapter.Fill(this.bookingsystemDBDataSet.Customer); //loading the data to fill
            this.movieTableAdapter1.Fill(this.bookingsystemDBDataSet.Movie); 

        }

        private void seatB1_Click(object sender, EventArgs e)
        {

        }

    

        private bool ValidateControls() // method that return bool to validate controls
        {
            errorProvider2.Clear();
            bool correct = true;

            if (txtName.Text == string.Empty && txtName.Enabled)
            {
                errorProvider2.SetError(txtName, "Empty");
                correct = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider2.SetError(txtSurname, "Empty");
                correct = false;
            }
            if (txtSurname.Text == string.Empty && txtSurname.Enabled)
            {
                errorProvider2.SetError(txtSurname, "Empty");
                correct = false;
            }
            if (txtTelephone.Text == string.Empty && txtTelephone.Enabled)
            {
                errorProvider2.SetError(txtTelephone, "Empty");
                correct = false;
            }
            if (txtMobile.Text == string.Empty && txtMobile.Enabled)
            {
                errorProvider2.SetError(txtMobile, "Empty");
                correct = false;
            }
            if (txtEmail.Text == string.Empty && txtEmail.Enabled)
            {
                errorProvider2.SetError(txtEmail, "Empty");
                correct = false;
            }
            if (txtID.Text == string.Empty && txtID.Enabled)
            {
                errorProvider2.SetError(txtID, "Empty");
                correct = false;
            }
            if (rchTxtAdress.Text == string.Empty && rchTxtAdress.Enabled)
            {
                errorProvider2.SetError(rchTxtAdress, "Empty");
                correct = false;
            }
            if (cbxTown.SelectedItem == null && cbxTown.Enabled)
            {
                errorProvider2.SetError(cbxTown, "Required");
                correct = false;
            }
            if (cbxGender.SelectedItem == null && cbxGender.Enabled)
            {
                errorProvider2.SetError(cbxGender, "Required");
                correct = false;
            }
            return correct;
        }

        private void cbxTheatre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSeats_Click(object sender, EventArgs e)
        {
            SeatForm seats = new SeatForm(); //loading the seats
            seats.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            mainMenu main = new mainMenu(); //showing the main menu
            this.Hide();
            main.ShowDialog();
        }

      

    }
}
