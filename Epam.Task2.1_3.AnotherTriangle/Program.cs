using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_3.AnotherTriangle
{
    class Program
    {
        static void Stroka(int n, char a)
        {
            for (short i = 1; i <= n; ++i)
            {
                Console.Write("{0}", a);
            }
        }

        static void Fun(int n)
        {
           /* for (int i = 0; i <= n/2; ++i)
            {
                Stroka(i, ' ');
                Stroka(n - 2 * i, '*');
                Console.WriteLine();
            } */

            for (int i = n/2; i>= 0; --i)
            {
                Stroka(i, ' ');
                Stroka(n - 2 * i, '*');
                Console.WriteLine();
            }
        }

     /*   static void Fun_Rec(int i, int n)
        {
            if (n>0)
            {
               // Stroka(i, ' ');
               // Stroka(n, '*');
              //  Console.WriteLine(); 

                Fun_Rec(i + 1, n - 2);
                Stroka(i, ' ');
                Stroka(n, '*');
                Console.WriteLine();
            }
        }
        */

        static void Main(string[] args)
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            Fun(n);
            //Fun_Rec(0, n);
        }
    }
}
