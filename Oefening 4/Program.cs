using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in");
            decimal getal1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Geef een tweede getal in");
            decimal getal2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Welke berekening wilt u uitvoeren?");
            Console.WriteLine("\n1.optellen \n2.aftrekken \n3.vermenigvuldigen \n4.delen");
            byte bewerking = byte.Parse(Console.ReadLine());
            switch (bewerking)
            {
                case 1:
                    decimal optelling = getal1 + getal2;
                    Console.WriteLine($"Het resultaat is {optelling}");
                    break;

                case 2:
                    decimal aftrekking = getal1 - getal2;
                    Console.WriteLine($"Het resultaat is {aftrekking}");
                    break;
                case 3:
                    decimal vermenigvuldiging = getal1 * getal2;
                    Console.WriteLine($"Het resultaat is {vermenigvuldiging}");
                    break;
                default:
                    decimal deling = getal1 / getal2;
                    Console.WriteLine($"Het resultaat is {deling}");
                    break;
            }
        }
    }
}
