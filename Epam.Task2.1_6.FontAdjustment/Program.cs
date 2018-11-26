using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._1_6.FontAdjustment
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            Console.WriteLine("Font propeties: ");
            int n;
            while ((true) && ((n == 1) || (n == 2) || (n == 3)))
            {
                Console.WriteLine("Options selected: ");
                Console.WriteLine("1: BOLD\n" +
                                  "2: ITALIC\n" +
                                  "3: UNDERLINE\n");

                n = char.Parse(Console.ReadLine());
                switch (n)
                {
                    case '1':
                        Console.WriteLine("Font propeties: Bold");
                        break;
                    case '2':
                        Console.WriteLine("Font propeties: Italic");
                        break;
                    case '3':
                        Console.WriteLine("Font propeties: Underline");
                        break;
                }
            }    
               

                    

                
            }
        }
    }
}
