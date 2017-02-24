using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class Booking
    {

        private int bookingId;

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }
        private List<Seat> seat;

        public Booking()
        {

        }

        public Booking(int bookingId)
        {
            this.bookingId = bookingId;
        }
    }
}

