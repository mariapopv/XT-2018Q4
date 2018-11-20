using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void Count(int n)
        {

            for (int i = 0; i <= n; i++)
            {

                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        
        }

        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your list of numbers: ");
            Count(n);
            
        }
    }
}
