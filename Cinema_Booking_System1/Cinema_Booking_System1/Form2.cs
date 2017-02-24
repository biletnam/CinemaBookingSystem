using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System1
{
        public partial class SeatForm : Form
        {
            private Theatre theatre;
            private Seat tmpSeat;
            private List<Seat> lstSeats;
            private Status defaultStatus;


            private int width;
            private int y;
            private int x;
            private int height;
            private int xSpacing;
            private int ySPacing;


            public SeatForm()
            {
                InitializeComponent();
                lstSeats = new List<Seat>();
                init();
                Generate(5, 5);
            }

            private void init()
            {
                width = 60;
                height = 60;
                defaultStatus = Status.Free;
                xSpacing = 60;
                ySPacing = 60;
            }


            private void Generate(int rows, int columns)
            {
                for (y = 0; y < rows; y++)
                {
                    for ( x = 0; x < columns; x++)
                    {
                        SeatB tmpSeat = new SeatB();
                        tmpSeat.Width = width;
                        tmpSeat.Height = height;
                        tmpSeat.Top = ySPacing * y;
                        tmpSeat.Left = xSpacing * x;
                        tmpSeat.SeatStatus = defaultStatus;
                        tmpSeat.Click += tmpSeat_Click;
                        tmpSeat.Text = "r" + y + "c" + x;
                        this.Controls.Add(tmpSeat);

                    }
                }


            }

            void tmpSeat_Click(object sender, EventArgs e)
            {
                SeatB tmpS = (SeatB)sender;
                if (tmpS.SeatStatus == Status.Free)
                {
                    tmpS.SeatStatus = Status.Purchased;
                    tmpSeat = new Seat(lstSeats.Count, x, y, Status.Purchased);
                    lstSeats.Add(tmpSeat);

                }
               
            }

            private void Form2_Load(object sender, EventArgs e)
            {
                this.seatTableAdapter.Fill(this.bookingsystemDBDataSet1.Seat);
            
                
            }

            private void btnOk_Click(object sender, EventArgs e)
            {
                foreach (Seat s in lstSeats)
                {
                    seatTableAdapter.Insert(s.SeatNo,s.Row,s.Column);
                }
                this.Hide();
            }

            private void bindingSource1_CurrentChanged(object sender, EventArgs e)
            {

            }
        }
    }



