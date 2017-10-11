using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            List<shape> Drawing = new List<shape>();
            Drawing.Add(new Circle(3));
            Drawing.Add(new Circle(4));

            Drawing.Add(new Triangle(3, 4));
            Drawing.Add(new Triangle(5, 7));

            Drawing.Add(new Rectangle(2, 5));
            Drawing.Add(new Rectangle(4, 10));

            //Calculate the area of the whole drawing 
            //sum 
            double sum = 0;
            for (int i = 0; i < Drawing.Count; i++)
            {   //add the area of each element (Shape)
                sum = sum + Drawing[i].GetArea();
            }   //i here is just an element 

            //other way to do it using for each

            foreach (shape Element in Drawing)
            {
                sum = sum + Element.GetArea();
            }
                 

            Console.WriteLine(sum);



        }
    }
}
