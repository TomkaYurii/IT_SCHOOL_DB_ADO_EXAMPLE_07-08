using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex_01.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { set; get; }

        public int ProfuctionId { get; set; }
        public Production Production { get; set; }


        public int ActorId { get; set; }
        public Actor Actor { get; set; }

    }
}
