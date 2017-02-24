using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema_Booking_System1
{
    public class Movie
    {
        private string name;//variable
        private Genre genre;
        private Rating rating;

        public string Name //encapsulation
        {
            get { return name; }
            set { name = value; }
        }


        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }



        public Rating Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public Movie()//default constructor
        {

        }

        public Movie(string name, Genre genre, Rating rating)//overloaded constructor
        {
            this.name = name;
            this.genre = genre;
            this.Rating = rating;
        }

        public string GetInfo()//getinfo
        {
            return "Name: " + name + "\n " + " Genre: " + genre + "\n " + "Rating: " + rating; 
        }
    }
}

