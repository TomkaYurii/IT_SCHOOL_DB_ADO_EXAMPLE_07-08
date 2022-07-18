using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Models
{
    public abstract class Production
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
    }



    public class Series : Production
    {
        public int NumberofEpisodes { get; set; }
    }

    public class Rating
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }
    }

    public class Character
    {
        public int Id { get; set; }
        public int ProfuctionId { get; set; }
        public string Name { set; get; }
        public int ActorId { get; set; }

    }

    public class Actor
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

}
