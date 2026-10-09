using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09._10
{
    internal class Action: Movie
    {
        public int AgeLimit { get; set; }
        public Action(string title, string year, string genre, double rating, double myrating, int seasons, double hours, int agelimit):
            base(title,year,genre,rating,myrating,seasons,hours)
        {
            this.AgeLimit = agelimit;
        }

        public override void Describe()
        {
            Console.WriteLine("This is action movie."); ;
            Console.WriteLine("Age Limit:"+ AgeLimit);
        }

    }
}
