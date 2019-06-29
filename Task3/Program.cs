using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals =
            {
                new Aquatic(0),
                new Arboreal(2),
                new Arial(5),
                new Subterranean(7),
                new Terrestrial(11)
            };

            Feeder feed = new Feeder();
            feed.Feed(mammals);

            Console.ReadKey();
        }
    }   
}
