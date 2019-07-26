using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MyList<T> : IMyList<T>
    {
        private T[] arrayT;

        public MyList()
        {
            this.arrayT = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return this.arrayT[index];
            }
            set
            {
                this.arrayT[index] = value;
            }
        } 

        public int Count
        {
            get
            {
                return this.arrayT.Length;
            }
            set
            {
                this.Count = value;
            }
        }


        public void Add(T item)
        {
            T[] newArray = new T[this.arrayT.Length + 1];
            this.arrayT.CopyTo(newArray, 0);
            this.arrayT = newArray;
            this.arrayT[newArray.Length - 1] = item;
        }

        public void Clear()
        {
            this.arrayT = new T[0];
        }

        public bool Contains(T item)
        {
            foreach (var element in this.arrayT)
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
            string info = String.Empty;
            info += this.Count + ": ";

            if (this.Count == 0)
                return "List is empty";

            for (int i = 0; i < this.arrayT.Length; i++)
            {
                info += " " + this.arrayT[i].ToString();
            }

            return info;
        }
    }
}
