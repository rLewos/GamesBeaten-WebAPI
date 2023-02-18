using GamesBeaten.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamesBeaten.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        public GameController() { }

        [HttpGet]
        public dynamic Get(int id)
        {
            return new {Id = 1, Title = "Nier Automata" };
        }

        [HttpPost("New")]
        public void New(string title)
        {
            Debug.WriteLine("New game saved: " + title);
        }

        [HttpGet]
        public Game GetGame(int id)
        {
            return new Game { Id = 1, Title = "Nier Automata" };
        }
    }
}
