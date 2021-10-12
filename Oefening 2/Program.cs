using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in");
            decimal getal1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Geef een tweede getal in");
            decimal getal2 = decimal.Parse(Console.ReadLine());

            if (getal1 < getal2)
            {
                Console.WriteLine($"{getal2} {getal1}");
            }
            else if (getal1 == getal2)
            {
                Console.WriteLine(getal1);
            }
            else 
            {
                Console.WriteLine($"{getal1} {getal2}");
            }
        }
    }
}
