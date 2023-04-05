using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class OddEven
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
          
            if (num%2==0)
            {
                Console.WriteLine("The no. is even");
            }
            else
            {
                Console.WriteLine("The no. is odd");
            }

           /* int num1, num2, result1, result2;

            num1 = 5;
            num2 = -3;

            result1 = num1;
            result2 = num2;

            Console.WriteLine(" positive no is=" + result1);
            Console.WriteLine("negative no is=" + result2);*/


        }
    }
 
}
