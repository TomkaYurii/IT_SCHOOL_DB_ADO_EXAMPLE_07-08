using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Models
{
    public class Actor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Character> Characters { get; set; } 
    }
}
