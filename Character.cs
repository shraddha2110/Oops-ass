using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class Character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Enter the character ");
            char ch = Convert.ToChar(Console.ReadLine());
            //int ch = Convert.ToChar(Console.ReadLine());

            //if (ch>='a' && ch<='z' && ch>='A' && ch <='Z')
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("is alphabet");

            }

          

            else if (ch >= '0')
            {
                //Console.WriteLine("is digit");
            }

            else
            {
                Console.WriteLine("is special character");
            }
        }
    }
}

