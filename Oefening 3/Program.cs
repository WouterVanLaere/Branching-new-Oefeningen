using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het cijfer van de figuur waarvan u de oppervlakte wilt berekenen");
            Console.WriteLine("1: Vierkant \n2: Driehoek \n3: Cirkel");
            byte figuur = byte.Parse(Console.ReadLine());
            switch (figuur)
            {
                case 1:
                    Console.WriteLine("Geef de lengte van een zijde in cm");

                    decimal zijdeVierkant = decimal.Parse(Console.ReadLine());
                    decimal oppVierkant = zijdeVierkant * zijdeVierkant;
                    Console.WriteLine($"De oppervlakte van het vierkant is {oppVierkant} cm²");
                    break;
                case 2:
                    Console.WriteLine("Geef de hoogte van de driehoek in cm");
                    decimal hoogteDriehoek = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Geef de basis van de driehoek in cm");
                    decimal basisDriehoek = decimal.Parse(Console.ReadLine());
                    decimal oppDriehoek = hoogteDriehoek * basisDriehoek / 2;
                    Console.WriteLine($"De oppervlakte van de driehoek is {oppDriehoek} cm²");
                    break;
                default:
                    Console.WriteLine("Geef de straal van de cirkel in cm");
                    decimal straalCirkel = decimal.Parse(Console.ReadLine());
                    decimal pie = 3.141592m;
                    decimal oppCirkel = straalCirkel * 2 * pie;
                    Console.WriteLine($"De oppervlakte van de cirkel is {oppCirkel} cm²");
                    break;
            }
            //if (figuur == 1)
            //{
            //    Console.WriteLine("Geef de lengte van een zijde in cm");

            //    decimal zijdeVierkant = decimal.Parse(Console.ReadLine());
            //    decimal oppVierkant = zijdeVierkant * zijdeVierkant;
            //    Console.WriteLine($"De oppervlakte van het vierkant is {oppVierkant} cm²");
            //}
            //else if (figuur == 2)
            //{
            //    Console.WriteLine("Geef de hoogte van de driehoek in cm");
            //    decimal hoogteDriehoek = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("Geef de basis van de driehoek in cm");
            //    decimal basisDriehoek = decimal.Parse(Console.ReadLine());
            //    decimal oppDriehoek = hoogteDriehoek * basisDriehoek / 2;
            //    Console.WriteLine($"De oppervlakte van de driehoek is {oppDriehoek} cm²");
            //}
            //else
            //{
            //    Console.WriteLine("Geef de straal van de cirkel in cm");
            //    decimal straalCirkel = decimal.Parse(Console.ReadLine());
            //    decimal pie = 3.141592m;
            //    decimal oppCirkel = straalCirkel * 2 * pie;
            //    Console.WriteLine($"De oppervlakte van de cirkel is {oppCirkel} cm²");
            //}
        }
    }
}
