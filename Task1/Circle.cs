using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Circle : Figure
    {
        public int Radius { get; set; }

        public Circle(int radius, int x, int y) :
            base(x, y)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"You draw the circles with side {this.Radius} and centre ({this.PointX}, {this.PointX})");
        }
    }
}
