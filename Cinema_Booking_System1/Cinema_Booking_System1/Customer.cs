using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class Customer:Human //based from human
    {
        private string emailAddress; //variable

        public string EmailAddress //encapsulating variable
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public Customer() //default constructor
        {

        }

        public Customer(string emailAddress, string name, string surname, string address, string idNumber, Town town, Gender gender, int mobileNumber, int telephoneNumber)
            : base(name, surname, address, idNumber, town, gender, mobileNumber, telephoneNumber) //overloaded constructor
        {
            this.emailAddress = emailAddress;
        }

        public string GetInfo()//get info
        {
            return Getinfo() + "\n EmailAddress: " + emailAddress;
        }
    }
}


