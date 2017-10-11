using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Rectangle:shape
    {
        private double ttlenght;
        private double ttwidth;

        public double Width
        {
            set { ttwidth = value; }
            get { return ttwidth;  }
        }

        public double Lenght
        {
            set { ttlenght = value; }
            get { return ttlenght;  }
        }

        public Rectangle()
        {
            Lenght = Width = 0;
        }

        public Rectangle(double w, double l)
        {
            Lenght = l;
            Width = w;

        }

        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }

        public override double GetArea()
        {
            return Lenght * Width;
        }
    }
}
