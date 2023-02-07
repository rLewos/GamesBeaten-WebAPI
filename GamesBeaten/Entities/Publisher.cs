using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesBeaten.Domain.Entities
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }

        public Publisher(string name)
        {
            Name = name;
        }
    }
}
