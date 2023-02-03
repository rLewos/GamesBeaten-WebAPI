using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesBeaten.Domain.Entities
{
    public class Developer : BaseEntity
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name= name;
        }
    }
}
