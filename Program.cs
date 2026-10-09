namespace _09._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> films = new List<Movie>();

            films.Add(new Movie("Fast and fourious", "2006", "Action", 9.8, 9.7, 5, 9, 34));
            films.Add(new Action("Mission:Impossible", "2023", "Action", 7.5, 4.3, 5, 34, 12));
            films.Add(new Comedy("Home Alone", "1990", "Comedy", 7.8, 8, 5, 34, "Steff Curry"));
            films.Add(new SuperheroFilm("Spider man", "2021", "Superhero films", 8.2, 6, 1, 14, 12, "Tobey Maguire"));

            foreach(Movie movie in films)
            {
                Console.WriteLine("\n===============");
                movie.Print();
                movie.Describe();
            }
        }

    }
}
