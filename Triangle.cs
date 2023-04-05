using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int b, h, c, area;

            b = 20;
            h = 15;
            c = b * h;

            area = c / 2;

            Console.WriteLine("Area of Triangle=" + area);
            //Console.WriteLine(area);
        }
    }
}
