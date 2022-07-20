using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }

        public int ProductionId { get; set; }
        public Production Production { get; set; }
    }
}
