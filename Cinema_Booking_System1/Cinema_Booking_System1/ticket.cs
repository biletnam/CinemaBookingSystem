using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class ticket
    {
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }
        private Theatre theatre;

        public Theatre Theatre
        {
            get { return theatre; }
            set { theatre = value; }
        }
        private Customer cust;

        public Customer Cust
        {
            get { return cust; }
            set { cust = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private Seat seat;

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        private TicketType type;

        public TicketType Type
        {
            get { return type; }
            set { type = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
      
        public ticket()
        {

        }
        public ticket(Movie movie, Theatre theatre, Customer cust, double price, Seat seat, TicketType type, int quantity)
        {
            this.movie = movie;
            this.theatre = theatre;
            this.cust = cust;
            this.price = price;
            this.seat = seat;
            this.type = type;
            this.quantity = quantity;
        }

        public string GetInfo()
        {
            return   "\n Price :" + price + "\n Quantity :" + quantity + "\n Type: " + type ;
        }

        public double GetPrice(TicketType typ)
        {
            double tmpPrice = 0;
            if (typ == TicketType.Adult)
            {
                tmpPrice = 8.00;
                return tmpPrice;
            }
            else if (typ == TicketType.Child)
            {
                tmpPrice = 5.50;
                return tmpPrice;
            }
            else
            {
                return tmpPrice;
            }
        }

        public double GenerateTicketPrice(double price,int quant)
        {
            double finalPrice = 0;
            finalPrice = price * quant;
            return finalPrice;
        }
    }
}
