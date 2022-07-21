using EntityFramework_Ex_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Contexts
{
    public class ProductionDbContext : DbContext
    {
        public DbSet<Production> Productions { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Rating> Ratings { get; set; }  
        public DbSet<Character> Characters { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public ProductionDbContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TOMKA;Database=efbasicsappdb;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            #region seed data

            var movies = new Movie[] {
                new Movie { Id = 1, Name = "Avengers: Endgame", WorldWideBoxOfficeGross = 27978, DurationInMinutes = 181, Release = new DateTime(2019, 4, 26) },
                new Movie { Id = 2, Name = "The Lion King", WorldWideBoxOfficeGross = 165479, DurationInMinutes  = 118, Release = new DateTime(2019, 7, 19) },
                new Movie { Id = 3, Name = "Ip Man 4", WorldWideBoxOfficeGross = 19261, DurationInMinutes = 105, Release = new DateTime(2019, 12, 25) },
                new Movie { Id = 4, Name = "Gemini Man", WorldWideBoxOfficeGross = 16662, DurationInMinutes = 116, Release = new DateTime(2019, 11, 20) },
                new Movie { Id = 5, Name = "Downton Abbey", WorldWideBoxOfficeGross = 19405, DurationInMinutes = 120, Release = new DateTime(2020, 9, 20 )}
            };

            var series = new Series[] {
                new Series { Id = 6 , Name = "The Fresh Prince of Bel-Air", NumberofEpisodes = 148, Release = new DateTime(1990, 9, 10) },
                new Series { Id = 7 , Name = "Downton Abbey", NumberofEpisodes = 52, Release = new DateTime(2010, 09, 26) },
                new Series { Id = 8 , Name = "Stranger Things", NumberofEpisodes = 34 , Release = new DateTime(2016, 7, 11) },
                new Series { Id = 9 , Name = "Kantaro: The Sweet Tooth Salaryman", NumberofEpisodes = 12, Release = new DateTime(2017,7, 14) },
                new Series { Id = 10, Name = "The Walking Dead", NumberofEpisodes = 177 , Release = new DateTime(2010, 10, 31) }
            };

            var productions = movies
                .Cast<Production>()
                .Union(series)
                .ToList();

            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Series>().HasData(series);

            // characters
            modelBuilder.Entity<Character>().HasData(new Character[]
            {
                // movies
                new Character { Id = 1, Name = "Tony Stark", ProductionId = 1, ActorId = 1 },
                new Character { Id = 2, Name = "Steve Rogers", ProductionId = 1, ActorId = 2 },
                new Character { Id = 3, Name = "Okoye", ProductionId = 1, ActorId = 3 },
                new Character { Id = 4, Name = "Simba", ProductionId = 2, ActorId = 4 },
                new Character { Id = 5, Name = "Nala", ProductionId = 2, ActorId = 5 },
                new Character { Id = 6, Name = "Ip Man", ProductionId = 3, ActorId = 6 },
                new Character { Id = 7, Name = "Henry Brogan", ProductionId = 4, ActorId = 7 },
                new Character { Id = 8, Name = "Violet Crawley", ProductionId = 5, ActorId = 8 },
                new Character { Id = 9, Name = "Lady Mary Crawley", ProductionId = 5, ActorId = 9 },
                // television
                new Character { Id = 10, Name = "Will Smith", ProductionId = 6, ActorId = 7},
                new Character { Id = 11, Name = "Hilary Banks", ProductionId = 6, ActorId = 10 },
                new Character { Id = 12, Name = "Violet Crawley", ProductionId = 7, ActorId = 8 },
                new Character { Id = 13, Name = "Lady Mary Crawley", ProductionId = 7, ActorId = 9 },
                new Character { Id = 14, Name = "Eleven", ProductionId = 8, ActorId = 11 },
                new Character { Id = 15, Name = "Lucas", ProductionId = 8, ActorId = 12 },
                new Character { Id = 16, Name = "Joyce Byers", ProductionId = 8, ActorId = 13 },
                new Character { Id = 17, Name = "Jim Hopper", ProductionId = 8, ActorId = 14 },
                new Character { Id = 18, Name = "Ametani Kantarou", ProductionId = 9, ActorId = 15},
                new Character { Id = 19, Name = "Sano Erika", ProductionId = 9, ActorId = 16 },
                new Character { Id = 20, Name = "Daryl Dixon", ProductionId = 10, ActorId = 17 },
                new Character { Id = 21, Name = "Michonne", ProductionId = 10, ActorId = 3 },
                new Character { Id = 22, Name = "Carol Peletier", ProductionId = 10, ActorId = 18 }
            });

            // actors
            modelBuilder.Entity<Actor>().HasData(new Actor[]
            {
                new Actor { id = 1, Name = "Robert Downey Jr." },
                new Actor { id = 2, Name = "Chris Evans" },
                new Actor { id = 3, Name = "Danai Guira" },
                new Actor { id = 4, Name = "Donald Glover" },
                new Actor { id = 5, Name = "Beyoncé" },
                new Actor { id = 6, Name = "Donny Yen" },
                new Actor { id = 7, Name = "Will Smith" },
                new Actor { id = 8, Name = "Maggie Smith" },
                new Actor { id = 9, Name = "Michelle Dockery" },
                new Actor { id = 10, Name = "Karyn Parsons" },
                new Actor { id = 11, Name = "Millie Bobby Brown" },
                new Actor { id = 12, Name = "Caleb McLaughlin" },
                new Actor { id = 13, Name = "Winona Ryder"},
                new Actor { id = 14, Name = "David Harbour" },
                new Actor { id = 15, Name = "Matsuya Onoe" },
                new Actor { id = 16, Name = "Hazuki Shimizu"},
                new Actor { id = 17, Name = "Norman Reedus" },
                new Actor { id = 18, Name = "Melissa McBride" }
            });

            // let's generate lots of ratings
            var random = new Random();
            var size = 100;
            var sources = new[] {
                "Internet",
                "Newspaper",
                "Magazine",
                "App"
            };

            var ratings = productions
                .SelectMany((production, index) => {

                    return Enumerable
                        .Range(index * 100 + 1, size - 1)
                        .Select(id => new Rating
                        {
                            Id = id,
                            ProductionId = production.Id,
                            Stars = random.Next(1, 6),
                            Source = sources[random.Next(0, 4)]
                        }).ToList();
                });

            modelBuilder.Entity<Rating>().HasData(ratings);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
