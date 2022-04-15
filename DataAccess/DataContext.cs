using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Game> Games { get; set; }
    
        static DataContext()
        {
            Games = new List<Game>();
        }
    }
}
