using EntityFramework_Ex_01.Contexts;
using System;
using System.Linq;

namespace EntityFramework_Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var database = new ProductionContext();

            var movies = database.Movies.OrderByDescending(x=>x.WorldWideBoxOfficeGross);

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.Name);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(movies);



            var HighRatingProduction = database
                .Productions
                .Select(x => new
                {
                    id = x.Id,
                    name = x.Name,
                    avg = x.Rating.Average(r => r.Stars),
                    type = x.GetType().Name
                })
                .OrderByDescending(x => x.avg);
        }
    }
}
