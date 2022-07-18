using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Models
{
    public class Movie : Production
    {
        public int DurationInMinutes { get; set; }
        public int WorldWideBoxOfficeGross { get; set; }
    }
}
