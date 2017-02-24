using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public abstract class Human
    {
        private string name; //declaring variable

        protected string Name //encapsulating the variable
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        protected string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string address;

        protected string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string idNumber;

        protected string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        private Gender gender;

        protected Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private Town town;

        protected Town Town
        {
            get { return town; }
            set { town = value; }
        }

        private int mobileNumber;

        protected int MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        private int telephoneNumber;

        protected int TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }

     

        
        public Human() //Default Constructor
        {
            this.name = "";
            this.surname = "";
            this.address = "";
            this.idNumber = "";
            this.town = Town.Burmarrad;
            this.gender = Gender.Female;
            this.mobileNumber = 000000;
            this.telephoneNumber = 000000;
        }

        public Human(string name, string surname, string address, string idNumber, Town town, Gender gender, int mobileNumber, int telephoneNumber)
            : this() //overloaded constructor
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.town = town;
            this.gender = gender;
            this.mobileNumber = mobileNumber;
            this.telephoneNumber = telephoneNumber;
        }

        public string Getinfo()//getinfo
        {
            return "Name: " + Name + "\nSurname: " + Surname + "\nAddress: " + Address + "\nTown: " + Town + "\nGender: " + Gender + "\nMobileNumber" + MobileNumber + "\ntelephoneNumber: " + TelephoneNumber;
        }

    }
}
