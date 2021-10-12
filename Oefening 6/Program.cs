using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een jaartal in");
            int jaar = int.Parse(Console.ReadLine());
            
            if (jaar %400 == 0)
            {
                Console.WriteLine($"Dit jaar had 29 dagen in februari");
            }
            else if (jaar %100 == 0)
            {
                Console.WriteLine($"Dit jaar had 28 dagen in februari");
            }
            else if (jaar %4 == 0)
            {
                Console.WriteLine($"Dit jaar had 29 dagen in februari");
            }
            else
            {
                Console.WriteLine($"Dit jaar had 28 dagen in februari");
            }
        }
    }
}
