using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_9
{
    class Program
    {
        static void Show(int[] mas)
        {
            foreach (int elem in mas)
            {
                Console.Write("{0} ", elem);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas;
            int n = rnd.Next(0, 10);
            mas = new int[10];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(10);
            }
            Console.WriteLine("Original array: ");
            Show(mas);

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                        if (mas[i] > 0)
                        {
                            result = mas[i] + result;
                        } 

            }
            Console.WriteLine("\nNon-negative sum: {0}", result);
        }
    }
}
