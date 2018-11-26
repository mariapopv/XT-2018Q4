using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");

            string s = Console.ReadLine();
            bool newW = true;
            int sum = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (newW)
                    {
                        count++;
                        newW = false;
                    }

                    sum++;
                }
                else
                {
                    newW = true;
                }
            }

            Console.WriteLine("Average length of the strings: {0}", (double)sum / count);
        }
    }
}
