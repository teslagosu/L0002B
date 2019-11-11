using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inl3
{
    class PersonController
    {
        //instans av personklassen
        Person p;

        //konstruktor
        public PersonController(Person p)
        {
            //hänvisar att this.p = person p
            this.p = p;
        }

        //funktion som kollar om personnummret är giltigt.
        public bool ssnIsValid(string ssn)
        {
            //trunkera längden på personnnummret med -1 så vi får fram kontrollsiffran sist.
            int truncatedLength = ssn.Length - 1;
            //returnar true eller false beroende på om sista kontrollsiffran är densamma som den ur den funktionen som skapar en kontrollsiffra.
            return ssn[truncatedLength] == createCheckNumber(ssn.Substring(0, truncatedLength));
        }

        //funktion som skapar ett kontrollnummer(sista siffran i personnummret)
        public static char createCheckNumber(string ssn)
        {
            int sum = 0;

            // i börjar på ssn[8] vilket är näst sista siffran av personnummret. sen stegar den ner 2 steg medans i är större än eller lika med 1.

            for (int i = ssn.Length - 1; i >= 1; i -= 2)
            {
                //  och gångrar varannan rad med 2, och skickar in den i en funktion som returnerar ett ihop ett tal som plussats ihop med ett annat t.ex. 14 = 1+4 och plussar sedan med dem som inte gångrats.
                sum += get2DigitSum((ssn[i] - '0') * 2) + (ssn[i - 1] - '0');
            }

            //plussar på ssn[0] * 2 i funktionen som returnerar ett tvåsiffrigt tal som plussats ihop med varandra.
            sum += get2DigitSum((ssn[0] - '0') * (ssn.Length % 2) * 2);

            //kontrollsiffran kommer till när vi tar 10 - sista siffran av sum(sum % 10)
            //om svaret skulle vara 10 så måste vi ta % 10 igen så att resultatet blir 0.
            return (char)(((10 - (sum % 10)) % 10) + '0');
        }

        //funktion som returnar summan av två siffor : t.ex. 14, 1+4 = 5.
        public static int get2DigitSum(int num)
        {
            return (num / 10) + (num % 10);

        }

        //funktion som returnar true eller false beroende på om det är en man eller kvinna.
        public  bool manOrWoman(string ssn)
        {
            int checkNumber = int.Parse(ssn.Substring(8, 1));
            if(checkNumber % 2 == 0)
            {
                return true;
            }
            return false;
        }






    }
}
