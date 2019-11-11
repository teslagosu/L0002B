using System;

namespace inlämningsuppgift1
{
    class Program
    {


        static void Main(string[] args)
        {
            // Variabler
            int[] valorer = new int[] { 500, 100, 50, 20 ,10 ,5 ,1 };
            string input;
            int pris = 0;
            int betalt = 0;


            //Try catch som fångar upp formatexception om användaren
            //matar in ett negativt värde.
            try{
                //Output för pris och input från användaren.
                Console.WriteLine("Ange pris: ");
                input = Console.ReadLine();
                pris = int.Parse(input);
            

            //Output för vad kunden betalat och inputen från användaren.
            Console.WriteLine("Betalt: ");
            input = Console.ReadLine();
            betalt = int.Parse(input);

            }
            catch (FormatException)
            {
                Console.WriteLine("Priset eller betalning från kund får ej vara negativt!");
            }
            //slut på try-catch

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
            Console.WriteLine("Pengar tillbaka till kund: " + totalSumma + "kr.");

                //foreach iteration som går igenom varje valör i sedlar-arrayen och spottar ut 
                foreach (int valor in valorer)
                {
                    int valorerTillbaka = totalSumma / valor;
                    totalSumma = totalSumma - (valorerTillbaka * valor);
                    if (valorerTillbaka > 0)
                    {
                        Console.WriteLine($"{valor}" + "kr: " + valorerTillbaka +"st");
                    }



            }

          

        }
    }
}
