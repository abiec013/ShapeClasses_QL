using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    abstract class shape
    {
        public abstract void Draw(); //shape
        //all abstract methods are virtual by deafult


        public abstract double GetArea();

        public override string ToString()
        {
            return  "The Area of this shape is: " + GetArea();

        }






    }
}
