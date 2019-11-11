using System;

namespace inlämningsuppgift1
{
    internal class Program1
    {


        public static void Main1(string[] args)
        {
            // Variabler
            int[] sedlar = new int[] { 500, 100, 50, 20 ,10 ,5 ,1 };
            string input;
            int pris;
            int betalt;

            //Output för pris och input från användaren.
            Console.WriteLine("Ange pris: ");
            input = Console.ReadLine();
            pris = int.Parse(input);

            //Output för vad kunden betalat och inputen från användaren.
            Console.WriteLine("Betalt: ");
            input = Console.ReadLine();
            betalt = int.Parse(input);

            //Beräkning för priset tillbaka
            int totalSumma = betalt - pris;

            //if-sats som kollar om kunden betalat för lite.
            if(betalt < pris){
                Console.WriteLine("Köpet går ej att genomföra, kunden har inte betalat tillräckligt!");
                return;
            }
            //Skriver ut pris, vad kunden betalat och hur mycket pengar kunden ska ha tillbaka.
            Console.WriteLine("Pris: " + pris);
            Console.WriteLine("Betalt: " + betalt);
            Console.WriteLine("Pengar tillbaka till kund: " + totalSumma);

            //foreach iteration som går igenom varje valör i sedlar-arrayen och spottar ut 
            foreach (int valor in sedlar){
               
                int valorerTillbaka = totalSumma / valor;
                totalSumma = totalSumma-(valorerTillbaka * valor);
                if(valorerTillbaka > 0){
                    Console.WriteLine($"{valor}" + "kr: " + valorerTillbaka);
                }



            }

          

        }
    }
}
