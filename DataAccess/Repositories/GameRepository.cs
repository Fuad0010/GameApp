using DataAccess;
using DataAccess.Interfaces;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    public class GameRepository : IRepository<Game>
    {
        public bool Create(Game entity)
        {
            try
            {
                DataContext.Games.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Game entity)
        {
            try
            {
                DataContext.Games.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Game entity)
        {
            try
            {
                Game isExist = GetOne(s => s.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Game GetOne(Predicate<Game> filter = null)
        {
            try
            {
                return DataContext.Games.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Game> GetAll(Predicate<Game> filter = null)
        {
            try
            {
                return DataContext.Games.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
