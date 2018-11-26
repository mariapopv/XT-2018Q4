using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = rnd.Next(10);
            int[,] mas = new int[n, n];
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)

                {
                    mas[j, k] = rnd.Next(-10, 10);

                }
            }

            Console.WriteLine("Original array: ");
            foreach (var elem in mas)
            {
                Console.Write("{0} ", elem);
            }

            int r = 0;
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    if ((k + j) % 2 == 0)
                    {
                        result += mas[j, k];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result: {0}", r);
        }
    }
}
