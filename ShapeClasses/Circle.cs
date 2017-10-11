using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Circle : shape
    {
        private double radius;

        public double Radius
        {
            set { radius = value; }
            get { return radius; }
        }


        public Circle()

        { Radius = 0; }

        public Circle(double r)
        {

            Radius = r;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
