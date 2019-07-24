using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Figure
    {
        public int  PointX { get; set; }

        public int PointY { get; set; }

        public Figure(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"You draw figure with centre ({this.PointX}, {this.PointX})");
        }
    }
}
