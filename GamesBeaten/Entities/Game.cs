using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesBeaten.Domain.Entities
{
    public class Game : BaseEntity
    {
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public IList<Plataform>? PlataformList { get; set; }

        public Game()
        {
            
        }

        public Game(string title)
        {
            Title = title;
        }

        public void AddPlataform(Plataform plataform)
        {
            if (plataform == null)
                throw new ArgumentNullException("Plataform is empty.");

            if (PlataformList == null)
                PlataformList = new List<Plataform>();

            PlataformList.Add(plataform);
        }
    }
}
