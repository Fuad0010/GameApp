using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class GameService : IGame
    {
        public static int Count { get; set; }
        private GameRepository _gamerepository;
        public GameRepository gamerepository { get; set; }
        public Game Create(Game game)
        {
            game.Id = Count;

            _gamerepository.Create(game);
            Count++;
            return game;
        }

        public Game Update(int id, Game game)
        {
            throw new NotImplementedException();
        }

        public Game Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Game GetGame(string name)
        {
            throw new NotImplementedException();
        }
    }
}
