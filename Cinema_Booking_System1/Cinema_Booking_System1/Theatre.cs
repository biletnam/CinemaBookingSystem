using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class Theatre
    {
        private int theatreNo;

        public int TheatreNo
        {
            get { return theatreNo; }
            set { theatreNo = value; }
        }
        private List<Seat> seats;

        public List<Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        private DateTime showTimes;

        public DateTime ShowTimes
        {
            get { return showTimes; }
            set { showTimes = value; }
        }

        public Theatre()
        {

        }

        public Theatre(int theatreNo, List<Seat> seats, DateTime  showTimes)
        {
            this.theatreNo = theatreNo;
            this.seats = seats;
            this.showTimes = showTimes;
        }

        public string GetInfo()
        {
            return " Theatre No:" + theatreNo + "   ShowTimes: " + ShowTimes;
        }
    }
}
