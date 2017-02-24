using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Cinema_Booking_System1
{
    class SeatB: Button
    {
        private Status seatStatus;

         internal Status SeatStatus
            {
            get { return seatStatus; }
            set { seatStatus = value;

            if(value == Status.Free)
            {
                this.BackColor = Color.Green;
            }
    
            else if(value == Status.Purchased)
            {
                this.BackColor = Color.Red;
            }


            }
        }

    }
}
