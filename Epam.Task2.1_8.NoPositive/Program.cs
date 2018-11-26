using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_8.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(5);
            int[,,] mas = new int[n, n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        mas[i, j, k] = rnd.Next(-10, 10);
                    }

                }

            }

            Console.WriteLine("Original array: ");

            foreach (var num in mas)
            {
                Console.Write(num + ", ");
            }

            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (mas[i, j, k] > 0)
                        {
                           mas[i, j, k] = 0;
                        }

                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine("Final array: ");

            foreach (var num in mas)
            {
                Console.Write(num + "; ");
            }

        }
    }
}
