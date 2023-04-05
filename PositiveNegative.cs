using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class PositiveNegative
    {

        static void Main(string[] args)
        {
            /*Console.WriteLine("  Enter the number ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)

            {
                Console.WriteLine("The no is negative  :");
            }
            else if (num > 0)
            {
                Console.WriteLine("The no is positive  :");
            }

            else
            {
                Console.WriteLine("zero :");
            }

            //else if 


        }
        /*static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number");
            int num = int.Parse(Console.ReadLine());
           
           if (num < 0)
          
            {
                Console.WriteLine("The no is negative");
            }
            else
             {
                Console.WriteLine("The no is positive");
            }*/

            //Implicitly Typed Arrays


            int sum = 0;

            foreach (int num in Sequence(5, 13))
            {
                sum += num;
            }



            Console.Write("Sum = " + sum);

        }

public static IEnumerable<int> Sequence(int start, int end)
        { 
for (int number = start + 1; number < end; number++) 
                if (number % 2 == 0 || number > 10)

                 
yield return number;
        }


    }
}
