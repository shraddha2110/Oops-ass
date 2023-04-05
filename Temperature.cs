using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Temperature
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;
            Console.WriteLine("Enter temp in celsius");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("temp in fahrenheit=" + fahrenheit);

            Console.WriteLine("Enter temp in fahrenheit");
            fahrenheit = float.Parse(Console.ReadLine());
            celsius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine("temp in celsius=" + celsius);
        }
    }
}
