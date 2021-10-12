using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_10
{
    class Program
    {
        static void Main(string[] args)
        {
            const string storedUserName = "Wouter";
            const string storedPassWord = "Password";

            Console.WriteLine("Geef uw username in");
            string userName = Console.ReadLine();
            Console.WriteLine("Geef uw wachtwoord in");
            string wachtWoord = Console.ReadLine();

            if ((userName == storedUserName && wachtWoord == storedPassWord))
            {
                Console.WriteLine("Ingelogd");
            }
            else
            {
                Console.WriteLine("Verkeerde ingave");
            }

        }
    }
}
