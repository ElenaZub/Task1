using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2
{
    class Program
    {
        public delegate void MyDelegate();

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            bool check = true;

            while (check)
            {
                Console.WriteLine("Enter number from 1 to 7");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            myDelegate1.Invoke();
                            break;
                        }
                    case "2":
                        {
                            myDelegate2.Invoke();
                            break;
                        }
                    case "3":
                        {
                            myDelegate3.Invoke();
                            break;
                        }
                    case "4":
                        {
                            MyDelegate myDelegate4 = myDelegate - myDelegate1;
                            myDelegate4.Invoke();
                            break;
                        }
                    case "5":
                        {
                            MyDelegate myDelegate5 = myDelegate - myDelegate2;
                            myDelegate5.Invoke();
                            break;
                        }
                    case "6":
                        {
                            MyDelegate myDelegate6 = myDelegate - myDelegate3;
                            myDelegate6.Invoke();
                            break;
                        }
                    case "7":
                        {
                            (myDelegate1 + myDelegate2).Invoke();
                            break;
                        }
                    case "0":
                        {
                            check = false;
                            break;
                        }
                    default:
                        Console.WriteLine("You enter incorrect value");
                        break;
                }
            }
           
        }
    }
}
