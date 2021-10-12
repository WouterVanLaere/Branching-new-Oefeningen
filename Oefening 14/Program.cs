using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int inschrijvingsGeld = 150;
            
            int kortingOuderDan50 = 20;
            int kortingPerKind = 10;
            int korting10Jaar = 10;
            int kortingPartner = 25;
            int totaalKorting;


            Console.WriteLine("Bent u ouder dan 50? \n\t.Ja \n\t.Nee");
            string ouderDan50 = Console.ReadLine();
            Console.WriteLine("Hoeveel kinderen heeft u ten laste?");
            int kinderenTenLaste = int.Parse(Console.ReadLine());
            int kinderKorting = kinderenTenLaste * kortingPerKind;
            Console.WriteLine("Sinds wanneer bent u lid?");
            int lidSindsJaar = int.Parse(Console.ReadLine());
            int lidTijd = 2021 - lidSindsJaar;
            Console.WriteLine("Is uw partner lid? \n\t.Ja \n\t.Nee");
            string partnerLid = Console.ReadLine();
            if (ouderDan50 == "ja")
            {
                if (lidTijd >= 10)
                {
                    if (partnerLid == "ja")
                    {
                        totaalKorting = kortingOuderDan50 + korting10Jaar + kortingPartner + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                    else
                    {
                        totaalKorting = kortingOuderDan50 + korting10Jaar + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                }
                else
                {
                    if (partnerLid == "ja")
                    {
                        totaalKorting = kortingOuderDan50 + kortingPartner + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                    else
                    {
                        totaalKorting = kortingOuderDan50 + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                }
            }
            else
            {

                if (lidTijd >= 10)
                {
                    if (partnerLid == "ja")
                    {
                        totaalKorting = korting10Jaar + kortingPartner + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                    else
                    {
                        totaalKorting = korting10Jaar + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                }
                else
                {
                    if (partnerLid == "ja")
                    {
                        totaalKorting = kortingPartner + (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                    else
                    {
                        totaalKorting = (kortingPerKind * kinderenTenLaste);
                        if (totaalKorting >= 60)
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - 60}");
                        }
                        else
                        {
                            Console.WriteLine($"U betaald {inschrijvingsGeld - totaalKorting}");
                        }
                    }
                }



            }




        }
    }
}
