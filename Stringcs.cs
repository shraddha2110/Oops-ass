using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Stringcs
    {
        static void Main(string[] args)
        {
           string str = "My name is shraddha";
            str = str.Replace(" ", string.Empty);
            while(str.Length>0)
            {
                int count = 0;
                Console.Write(str[0] + " ");
                for(int i=1;i<str.Length;i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);

            }
        }
    }
}
