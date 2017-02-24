using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
   public class Employee:Human
    {
        private EmployeeType employeeType; //declaring variables
        private Position position;
        private string password;
        private string user;

        public string User //encapsulating
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public Employee()//default constructor
        {
        }

        public Employee(Position position, EmployeeType employeeType,string password,string user, string name, string surname, string address, string idNumber, Town town, Gender gender, int mobileNumber, int telephoneNumber)
            : base(name, surname, address, idNumber, town, gender, mobileNumber, telephoneNumber)//overloaded constructor
        {
            this.position = position;
            this.employeeType = employeeType;
            this.password = password;
            this.user = user;
        }

        public string GetInfo()//getinfo
        {
            return Getinfo() + "\nPosition: " + Position + "\nEmployeeType" + employeeType;
        }


    }
}

