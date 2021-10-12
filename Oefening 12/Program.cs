using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_12
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal prijsMaaltijd = 4;
            decimal prijsWoensMaaltijd = 5;

            Console.WriteLine("Hoeveel maaltijden heeft u gegeten deze week?");
            decimal aantalMaaltijden = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Heeft u op woensdag gegeten?");
            string gegetenWoensdag = Console.ReadLine();
            Console.WriteLine("Sinds wanneer werkt u hier?");
            int beginJaar = int.Parse(Console.ReadLine());
            int jarenGewerkt = 2021 - beginJaar;

            if (aantalMaaltijden == 5)
            {
                if (jarenGewerkt >= 5)
                {
                    Console.WriteLine($"u betaald {12 / 5 * 4}");
                }
                else
                {
                    Console.WriteLine("U betaald 12 Euro");
                }

            }
            else if (gegetenWoensdag == "ja")
            {
                if (jarenGewerkt >= 5)
                {
                    Console.WriteLine($"U betaald {((aantalMaaltijden - 1) * prijsMaaltijd + prijsWoensMaaltijd) / 5 * 4}");
                }
                else
                {
                    Console.WriteLine($"U betaald {(aantalMaaltijden - 1) * prijsMaaltijd + prijsWoensMaaltijd}");
                }
            }
            else if (gegetenWoensdag == "nee")
            {
                if (jarenGewerkt >= 5)
                {
                    Console.WriteLine($"{(aantalMaaltijden * prijsMaaltijd) / 5 * 4}");
                }
                else
                {
                    Console.WriteLine($"U betaald {aantalMaaltijden * prijsMaaltijd}");
                }
            }
        }
    }
}
