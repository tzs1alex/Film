using System;
using System.Collections.Generic;
using System.Text;

namespace _09._10
{
    internal class SuperheroFilm: Action
    {
        public string Hero {  get; set; }
        public SuperheroFilm(string title, string year, string genre, double rating, double myrating, int seasons, double hours,int agelimit, string hero) :
            base(title,year,genre,rating,myrating,seasons,hours,agelimit)
        {
            this.Hero = hero;
        }
        public override void Describe()
        {
            Console.WriteLine("This is Superhero movie.");
            Console.WriteLine("SuperHero:" + Hero);
        }
    }
}
