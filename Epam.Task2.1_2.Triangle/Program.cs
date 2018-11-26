using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_2Triangle
{
    class Program
    {
        static void Stroka (int n)
        {
            for (int i = 1; i <= n; ++i)
            {
                Console.Write('*');
                
            }
            Console.WriteLine();
        }

        static void Fun(short n)
        {
            for (short i = 1; i <= n; ++i)
            {
                Stroka(i);
            }
        }

      /*  static void Fun_Rec(int i, short n)
        {
            if (i <= n)
            {
                Stroka(i);
                Fun_Rec(i + 1, n);
            }
        }
        */

        static void Main(string[] args)
        {
            
            Console.Write("Enter n = ");
            short n = short.Parse(Console.ReadLine());
            Fun(n);
          //  Fun_Rec(1, n);
        }
    }
}
