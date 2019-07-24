using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle : Figure
    {
        public int Side { get; set; }

        public int Height { get; set; }

        public Triangle(int side, int height, int x, int y) :
            base(x, y)
        {
            this.Side = side;
            this.Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"You draw triangle with side {this.Side}, height {this.Height}, centre ({this.PointX}, {this.PointX})");
        }
    }
}
