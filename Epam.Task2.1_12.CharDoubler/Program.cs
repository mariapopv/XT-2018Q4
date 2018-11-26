using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_12.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            var s = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            var s1 = Console.ReadLine();

            char[] mas = s1.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (mas.Contains(s[i]))
                {
                    s = s.Insert(i, s[i].ToString());
                    i++;
                }
            }
            Console.WriteLine("Result: \n{0}", s);
        }
    }
}
