using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel dieren heeft u?");
            int dierenAantal = int.Parse(Console.ReadLine());

            if (dierenAantal > 4)
            {
                Console.WriteLine("Amai, wie geeft dat allemaal te eten?");
            }
            else if (dierenAantal == 4)
            {
                Console.WriteLine("Gezellige beestenboel");
            }
            else if (dierenAantal == 3)
            {
                Console.WriteLine("Leuke bende");
            }
            else if (dierenAantal == 2)
            {
                Console.WriteLine("Komen ze een beetje overeen?");
            }
            else if (dierenAantal == 1)
            {
                Console.WriteLine("Is het beestje niet eenzaam?");
            }
            else if (dierenAantal == 0)
            {
                Console.WriteLine("Geen dierenvriend?");
            }
            else
            {
                Console.WriteLine("Je kan niet een negatief aantal dieren bezitten");
            }
        }
    }
}
