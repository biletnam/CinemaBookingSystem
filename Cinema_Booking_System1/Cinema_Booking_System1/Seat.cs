using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class Seat 
    {
        private int seatNo;//declaring variables
        private int column;
        private int row;
        private Status status;

        public Status Status //encapsulating
        {
            get { return status; }
            set { status = value; }
        }

        public int SeatNo
        {
            get { return seatNo; }
            set { seatNo = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public Seat()//default constructor
        {

        }

        public Seat(int seatNo, int row, int column,Status status) //overloaded constructor
        {
            this.seatNo = seatNo;
            this.row = row;
            this.column = column;
            this.status = status;
        }


    }
}

