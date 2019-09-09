using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CarCollectionManager
    {
        private CarCollection<Car> myList = new CarCollection<Car>();

        public void Execute()
        {
            myList.Add(new Car("Honda", 2018));
            myList.Add(new Car("Nissan", 2005));
            myList.Add(new Car("Bentley", 2014));
            myList.Add(new Car("BMW", 1970));

            Console.WriteLine(myList.ToString());

            Car carFirst = new Car("Nissan", 2005);
            this.Contain(carFirst);

            Car carSecond = new Car("Nissan", 2006);
            this.Contain(carSecond);

            Console.WriteLine(myList.ToString());

            myList.Clear();

            Console.WriteLine(myList.ToString());
            var tmp = myList[carFirst.Name];
            Console.WriteLine(tmp.ToString());

        }

        private void Contain(Car car)
        {
            if (myList.Contains(car))
            {
                Console.WriteLine($"List contains {car.ToString()}");
            }
            else
            {
                Console.WriteLine($"List does not contain {car.ToString()}");
            }
        }
    }
}
