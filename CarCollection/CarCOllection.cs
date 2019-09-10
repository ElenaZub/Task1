using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class CarCollection<T> : ICarCOllection<T> where T : Car
    {
        private T[] carArray;

        public CarCollection()
        {
            this.carArray = new T[0];
        }


        public T this[string name]
        {
            get
            {
                T element = default(T);

                for (int i = 0; i < this.Count; i++)
                {
                    if (this.carArray[i].Name.Equals(name))
                    {
                        element = this.carArray[i];
                        break;
                    }
                }
                return element;
            }
        }


        public int Count
        {
            get
            {
                return this.carArray.Length;
            }
        }


        public void Add(T item)
        {
            T[] newArray = new T[this.carArray.Length + 1];
            this.carArray.CopyTo(newArray, 0);
            this.carArray = newArray;
            this.carArray[newArray.Length - 1] = item;
        }

        public void Clear()
        {
            this.carArray = new T[0];
        }

        public bool Contains(T item)
        {
            foreach (var element in this.carArray)
            {
                if (Object.Equals(element, item))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string list = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                list += this.carArray[i].Name + " " + this.carArray[i].Year + "| ";
            }

            if(this.Count == 0)
                return "Car park is empty.";
            else
                return $"Size: {Count}, Park: {list}";
        }
    }
}
