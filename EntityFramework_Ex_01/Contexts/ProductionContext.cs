using EntityFramework_Ex_01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Contexts
{
    public class ProductionContext : DbContext
    {
        public DbSet<Production> Productions { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Rating> Ratings { get; set; }  
        public DbSet<Character> Characters { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public ProductionContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TOMKA;Database=efbasicsappdb;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            var movies = new Movie[]
            {
                new Movie {Id = 1, Name = "0000skdngksd", WorldWideBoxOfficeGross = 20000000, Release = new DateTime(2000,6,20), DurationInMinutes = 190  },
                new Movie {Id = 2, Name = "1111sd", WorldWideBoxOfficeGross = 20000000, Release = new DateTime(2020,6,20), DurationInMinutes = 120  },
                new Movie {Id = 3, Name = "2222skdngksd", WorldWideBoxOfficeGross = 20000000, Release = new DateTime(2010,6,20), DurationInMinutes = 150  }
            };

            var series = new Series[]
            {
                new Series {Id = 4, Name = "asafsafdasd", NumberofEpisodes = 400, Release = new DateTime(2000,6,20)  },
                new Series {Id = 5, Name = "asfsdfsd", NumberofEpisodes = 4400, Release = new DateTime(2000,6,20)  },
                new Series {Id = 6, Name = "a1231234124sd", NumberofEpisodes = 400, Release = new DateTime(2100,6,20)  },
            };
            var productions = movies
                .Cast<Production>()
                .Union(series)
                .ToList();

            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Series>().HasData(series);

            modelBuilder.Entity<Character>().HasData(new Character[]
            {
                new Character { Id = 1, Name = "sdgsdg", ProfuctionId = 1, ActorId = 1},
                new Character { Id = 2, Name = "sdwwerweg", ProfuctionId = 2, ActorId = 2},
                new Character { Id = 3, Name = "s123124dg", ProfuctionId = 1, ActorId = 3},

                new Character { Id = 4, Name = "s3254dg", ProfuctionId = 4, ActorId = 3},
                new Character { Id = 5, Name = "s35sdg", ProfuctionId = 6, ActorId = 2},
                new Character { Id = 6, Name = "sdgs234g", ProfuctionId = 5, ActorId = 1},
            });

            modelBuilder.Entity<Actor>().HasData(new Actor[]
            {
                new Actor { id = 1, Name = "QQQQQQQ"},
                new Actor { id = 2, Name = "QQQQQQQ"},
                new Actor { id = 3, Name = "QQQQQQQ"}
            });

            var random = new Random();
            var size = 10;
            var source = new[] {
                "Internet",
                "NewsPapers",
                "Magazine",
                "Group"
            };

            var rating = productions
                .SelectMany((production, index) =>
                {
                    return Enumerable
                    .Range(index * 10 + 1, size - 1)
                    .Select(id => new Rating
                    {
                        Id = id,
                        ProductionId = production.Id,
                        Stars = random.Next(1, 8),
                        Source = source[random.Next(0,4)]
                    }).ToList();
                });

            modelBuilder.Entity<Rating>().HasData(rating);

            base.OnModelCreating(modelBuilder);
        }

    }
}
