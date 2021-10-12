using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel_2_Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal a (ondergrens bereik 1)");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal b (bovengrens bereik1)");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal c (ondergrens bereik 2)");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef een getal d (bovengrens bereik 1");
            int d = int.Parse(Console.ReadLine());

            if (a < c && b > d)
            {
                Console.WriteLine("Bereik 2 valt volledig binnen bereik 1");
            }
            else
            {
                Console.WriteLine("Bereik 2 valt niet volledig binnen bereik 1");
            }
        }

    }
}
