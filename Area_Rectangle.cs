using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Area_Rectangle
    {
        static void Main(string[] args)
        {
            int l, b;

            l = 40;
            b = 30;
            double area = l * b;
            double perimeter = 2*(l + b);
            Console.WriteLine("Area of rectangle=" + area);
            Console.WriteLine("Perimeter of rectangle=" + perimeter);

            //Console.WriteLine(area);
        }
    }
}
