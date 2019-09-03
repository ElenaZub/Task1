using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Square : Figure
    {
        public int Side { get; set; }

        public Square(int side, int x, int y) :
            base(x, y)
        {
            this.Side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"You draw square with side {this.Side} and centre ({this.PointX}, {this.PointX})");
        }
    }
}
