using DataAccess;
using Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businies
{
    
        public class Class1
        {

            Repository<Game> game = new Repository<Game>();
            public List<Game> GetAll()
            {
                return game.List();
            }



        }
    
}
