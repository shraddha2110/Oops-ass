using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class total_average_percentage
    {
        static void Main(string[] args)
        {
            float maths, science, physics, chemistry, marathi;
            float total, average, percentage;

            maths = 70;
            science = 73;
            physics = 56;
            chemistry = 88;
            marathi = 65;

            total = maths + science + physics + chemistry + marathi;

            average = total / 5;

            percentage = (total / 500) * 100;

            //Console.WriteLine(result);
            //Console.WriteLine(total);
            Console.WriteLine("Total=" + total);
            Console.WriteLine("Average=" + average);
            Console.WriteLine("Percentage=" + percentage);
        }
    }
}