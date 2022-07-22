using Businies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProje
{
   class program
    {


        static void Main(string[]args)
        {
            Class1 cl=new Class1();
            foreach (var  item in cl.GetAll())
            {
                Console.WriteLine("İD:" + " " + item.gameid + " " + "Oyun Adı:" + " " + item.gamename);
            }


        }
    }
}
