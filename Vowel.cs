using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Enter the character ");
            char ch = Convert.ToChar(Console.ReadLine());


            if(ch == 'a' || ch == 'o' || ch == 'e' || ch == 'i' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }
            
        }
    }
}
