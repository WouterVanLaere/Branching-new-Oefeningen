using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_16
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal korting;
            decimal eindBedrag;
            Console.WriteLine("Voor hoeveel euro is er kleding angekocht?");
            decimal aankoopBedrag = decimal.Parse(Console.ReadLine());

            if (aankoopBedrag >= 25 && aankoopBedrag < 50)
            {
                korting = 0.01m;
                eindBedrag = aankoopBedrag - (aankoopBedrag * korting);
                Console.WriteLine($"U betaald {eindBedrag}");
            }
            else if (aankoopBedrag >= 50 && aankoopBedrag < 75)
            {
                korting = 0.02m;
                eindBedrag = aankoopBedrag - (aankoopBedrag * korting);
                Console.WriteLine($"U betaald {eindBedrag}");
            }
            else if (aankoopBedrag >= 75 && aankoopBedrag < 100)
            {
                korting = 0.03m;
                eindBedrag = aankoopBedrag - (aankoopBedrag * korting);
                Console.WriteLine($"U betaald {eindBedrag}");
            }
            else if (aankoopBedrag >= 100)
            {
                korting = 0.05m;
                eindBedrag = aankoopBedrag - (aankoopBedrag * korting);
                Console.WriteLine($"U betaald {eindBedrag}");
            }
            else
            {
                Console.WriteLine($"U betaald {aankoopBedrag}");
            }
        }
    }
}
