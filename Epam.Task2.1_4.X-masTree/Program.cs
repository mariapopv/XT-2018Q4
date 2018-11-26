using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_4.X_masTree
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Error!");
            }
            
            for (int j = 0; j <= n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    for (int m = 1; m < n-i; m++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        if (k == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("**");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
