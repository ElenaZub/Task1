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
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Add(1);
            list.Add(5);
            list.Add(8);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            if (list.Contains(1))
            {
                Console.WriteLine("This item is contained in array");
            }
            else
            {
                Console.WriteLine("This item is NOT contained in array");
            }

            list.Clear();
            Console.WriteLine($"Count after clearing: {list.Count}");
        }

        public MyList<int> CreateList()
        {
            MyList<int> myList = new MyList<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(rand.Next(100));
            }
            return myList;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
