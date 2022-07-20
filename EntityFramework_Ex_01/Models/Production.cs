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

        public List<Character> Character { get; set; }
        public List<Rating> Rating { get; set; }   
    }
}
