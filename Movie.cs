using System;
using System.Collections.Generic;
using System.Text;

namespace _09._10
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public double Myrating { get; set; }
        public int Seasons { get; set; }
        public double Hours { get; set; }

        public Movie(string title, string year,string genre, double rating,double myrating, int seasons, double hours)
        {
            this.Title = title;
            this.Year = year;
            this.Genre = genre;
            this.Rating = rating;
            this.Myrating = myrating;
            this.Seasons = seasons;
            this.Hours = hours;
        }

        public void Print()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Rating: " + Rating);
            Console.WriteLine("Myrating: " + Myrating);
            if (Seasons > 0)
            {
                Console.WriteLine("Seasons: " + Seasons);
            }
            else Console.WriteLine("Seasons: not have.");
            Console.WriteLine("Duration"+ Hours);
        }

        public virtual void Describe()
        {
            Console.WriteLine("Standard film.");
        }

    }
}
