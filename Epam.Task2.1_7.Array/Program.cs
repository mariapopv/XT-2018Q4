using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_7.Array
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
        
        static int MinMax(int[] mas, bool f)
        {
            if (f)
            {
                int min = mas[0];
                foreach (int elem in mas)
                {
                    if (elem < min)
                    {
                        min = elem;
                    }
                }
                return min;
            }
            else
            {
                int max = mas[0];
                foreach (int elem in mas)
                {
                    if (elem > max)
                    {
                        max = elem;
                    }
                }
                return max;
            }
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
            Console.WriteLine("Original array");
            Show(mas);

            Console.WriteLine("Max: {0}", MinMax(mas, false));
            Console.WriteLine("Min: {0}", MinMax(mas, true));

            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }

            Console.WriteLine("New Array");
            Show(mas);
        }
    }
}
