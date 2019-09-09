using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ListManager
    {
        private MyList<int> myList = new MyList<int>();

        public void Execute()
        {
            myList.Add(1);
            myList.Add(121);
            myList.Add(4);
            myList.Add(73);
            myList.Add(61);
            myList.Add(9);

            Console.WriteLine(myList.ToString());

            int value = 7;

            if (myList.Contains(value))
            {
                Console.WriteLine($"List contains {value}");
            }
            else
            {
                Console.WriteLine($"List does not contain {value}");
            }

            Console.WriteLine(myList.ToString());

            myList.Clear();

            Console.WriteLine(myList.ToString());
        }
    }
}
