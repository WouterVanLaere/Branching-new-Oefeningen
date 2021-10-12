using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aankop bedrag in in Euro");
            int aankoopBedrag = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het verkoop bedrag in in Euro");
            int verkoopBedrag = int.Parse(Console.ReadLine());
            int winst = verkoopBedrag - aankoopBedrag;

            if (winst > 0)
            {
                Console.WriteLine($"Uw winst is {winst}");
            }
            else if (winst < 0)
            {
                Console.WriteLine($"Uw verlies is {winst}");
            }
            else
            {
                Console.WriteLine("U heeft geen winst of verlies");
            }
        }
    }
}
