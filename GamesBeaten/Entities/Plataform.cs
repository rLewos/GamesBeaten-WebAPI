using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesBeaten.Domain.Entities
{
    public class Plataform : BaseEntity
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public Plataform(string name, string abbreviation)
        {
            Name = name;
            Abbreviation = abbreviation;
        }

        public Plataform()
        {
        }
    }
}
