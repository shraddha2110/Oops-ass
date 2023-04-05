using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Arithmetic 
    {
        static void Main(string[] args)
        {
            int m, n, sum, sub, mul, div;
            m = 55;
            n = 5;
            sum = m + n;
            sub = m - n;
            mul = m * n;
            div = m / n;

            //Console.WriteLine(result);
            Console.WriteLine("Sum=" + sum);
            Console.WriteLine("Substraction=" + sub);
            Console.WriteLine("Multiplication=" + mul);
            Console.WriteLine("Division=" + div);
        }
    }
}
