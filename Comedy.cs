using System;
using System.Collections.Generic;
using System.Text;

namespace _09._10
{
    internal class Comedy: Movie
    {
        public string Actor {  get; set; }
        public Comedy(string title, string year, string genre, double rating, double myrating, int seasons, double hours, string actor) :
            base(title, year, genre, rating, myrating, seasons, hours)
        {
            this.Actor = actor;
        }

        public override void Describe()
        {
            Console.WriteLine("This is comedy movie.");
            Console.WriteLine("Actor:"+Actor);
        }

    }
}
