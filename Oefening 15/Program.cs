using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oefening_15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber1 = random.Next(0,6);
            int randomNumber2 = random.Next(0, 6);
            int randomNumber3 = random.Next(0, 6);

            Console.WriteLine("Wat is uw inzet voor dit spel?");
            int inzet = int.Parse(Console.ReadLine());
            int score = inzet;

           //int  randomNumber1 = Rnd();
           //int  randomNumber2 = Rnd();
           //int  randomNumber3 = Rnd();

            Console.WriteLine($"De getallen zijn {randomNumber1}, {randomNumber2}, en {randomNumber3}");

            if (randomNumber1 == randomNumber2 && randomNumber2 == randomNumber3)
            {
                score = inzet * 3;
                Console.WriteLine($"Uw score is {score}");
            }
            else if (randomNumber1 != randomNumber2 && randomNumber2 != randomNumber3)
            {
                score = score - inzet;
                Console.WriteLine($"Uw score is {score}");
            }
            else
            {
                score = inzet * 2;
                Console.WriteLine($"Uw score is {score}");
            }
        }

        //static int Rnd()
        //{
        ////    Random random1 = new Random();
        ////    int randomNumber1 = random1.Next(1,100);
        ////    Thread.Sleep(1000);
        ////    return randomNumber1;
        ////}
    }
}
