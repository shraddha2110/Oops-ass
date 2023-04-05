using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Equi_Triangle
    {
        static void Main(string[] args)
        {
            int side;
            side = 75;
            double area = (1.732 / 4) * (side * side);
            Console.WriteLine("Area of equi triangle=" + area);
        }
    }
}
