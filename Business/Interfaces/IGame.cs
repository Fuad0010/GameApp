using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGame
    {
        Game Create(Game game);
        Game Update(int id,Game game);
        Game Delete(int id);
        Game GetGame(string name);
    }
}
