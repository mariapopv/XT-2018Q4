using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_5.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            for (int i = 1; i <= 999; i++)
            {
                if (((i % 3 == 0) || (i % 5 == 0)) && (i % 15 != 0))
                {
                    r += i;
                }
            }
            r += 15;
            Console.WriteLine("The sum of numbers from 1 to 1000 multiples of 3 and 5 is equal to {0}", r);
        }
    }
}
