using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2
{
    class Program
    {
        static int Square(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            if ((a <= 0) || (b <= 0))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                int s = Square(a, b);
                Console.WriteLine("The square of your rectangle is {0}", s);
            }

        }
    }
}
