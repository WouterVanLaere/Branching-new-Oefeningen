using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel_2_Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het x coördinaat van de rechthoek");
            int xCoördVierhoek = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het y coördinaat van de rechthoek");
            int yCoördVierhoek = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de breedte van de rechthoek");
            int breedteVierhoek = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef de hoogte van de rechthoek");
            int hoogteVierhoek = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het x coördinaat van het punt");
            int xCoördPunt = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef het x coördinaat van het punt");
            int yCoördPunt = int.Parse(Console.ReadLine());

            if (xCoördPunt > xCoördVierhoek && xCoördPunt < (xCoördVierhoek + breedteVierhoek))
            {
                if (yCoördPunt > yCoördVierhoek && yCoördPunt < (yCoördVierhoek + hoogteVierhoek))
                {
                    Console.WriteLine("Het punt ligt in de rechthoek");
                }
                else
                {
                    Console.WriteLine("Het punt ligt niet in de rechthoek");
                }
            }
            else
            {
                Console.WriteLine("Het punt ligt niet in de rechthoek");
            }

        }
    }
}
