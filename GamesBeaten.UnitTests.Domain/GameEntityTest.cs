using GamesBeaten.Domain.Entities;

namespace GamesBeaten.Tests.Domain
{
    public class GameEntityTest
    {
        [Fact]
        public void CreateGame()
        {
            //  Arrange
            //  Act
            Game game = new Game("Nier Automata");
            game.ReleaseDate = DateTime.Now;

            Plataform plataform = new Plataform();
            plataform.Id = 1;
            plataform.Name = "PlayStation 4";
            plataform.Abbreviation = "PS4";

            game.AddPlataform(plataform);

            //  Assert
            Assert.Equal("Nier Automata", game.Title);
            Assert.Equal("PlayStation 4", game.PlataformList.FirstOrDefault(x => x.Name == "PlayStation 4").Name);
        }
    }
}
