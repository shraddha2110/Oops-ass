using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Simple_Interest
    {
        static void Main(string[] args)
        {
            float P, R, T, SI;
            P = 15000;
            R = 45;
            T = 4;

            SI = (P * R * T) / 100;

            Console.WriteLine("SIMPLE INTEREST IS=" + SI);
        }
    }
}
