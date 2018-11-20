using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if ((number <= 1) && (number % 2 == 0))
            {
                return false;
            }
            else
            {
                if (number == 2)
                {
                    return true;
                }

               /* else
                {
                    if (number % 2 == 0)
                    {
                        return false;
                    }
                }*/
            }
            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Accept number:");
            int number = int.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            } 
        }
    }
}
