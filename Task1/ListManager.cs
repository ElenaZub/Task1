using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ListManager
    {
        public void Execute()
        {
            

        }

        public void CreateList()
        {
            IMyList<int> myList = new MyList<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(rand.Next(100));
            }
        }
    }
}
