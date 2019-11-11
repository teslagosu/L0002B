using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class PersonController
    {
        //instansvariabler
        List<Person> level1 = new List<Person>();   //lista för nivå1
        List<Person> level2 = new List<Person>();   //lista för nivå2
        List<Person> level3 = new List<Person>();   //lista för nivå3   
        List<Person> level4 = new List<Person>();   //lista för nivå4
        private Program view; 

        //Controller
        public PersonController(Program view)
        {
            this.view = view;   //referens av view
        }

        //funktion som skapar en ny säljare
        public void createNewSalesPerson()
        {
            int numberOfEmployees = 0;               //antal säljare, default = 0
            while (numberOfEmployees < 6)            //kör så länga antalet anställda är mindre än 6st.
            {
                Console.WriteLine("Namn: ");        //skriver ut Namn:    
                string name = Console.ReadLine();   //input från användaren
                Console.WriteLine("Persnr: ");      //skriver ut persnr:
                string id = Console.ReadLine();     //input från användaren
                Console.WriteLine("Distrikt: ");    //skriver ut distrikt:
                string district = Console.ReadLine();   //input från användaren
                Console.WriteLine("Antal: ");       //skriver ut antal:
                int quantity = Convert.ToInt32(Console.ReadLine());     //input från användaren som konverteras till int.

                Person p = new Person(name, id, district, quantity);    //Nytt objekt av klassen Person
                
                
                if (quantity < 50)  //om antal är mindre än 50
                {
                    level1.Add(p);  //lägg till personobjektet i level1 listan
                    numberOfEmployees++;    //plussa på antal säljare med 1
                }
                else if ( quantity >=50 && quantity < 100)  //om antal är större eller lika med  50 och mindre än 100
                {
                    level2.Add(p);  //lägg till personobjektet i level2 listan
                    numberOfEmployees++;    //plussa på antal säljare med 1
                }
                else if (quantity >= 100 && quantity < 200) //om antal är större eller lika med  100 och mindre än 200
                {
                    level3.Add(p);  //lägg till personobjektet i level3 listan
                    numberOfEmployees++;    //plussa på antal säljare med 1
                }
                else if(quantity >= 200)    //om antal är större eller lika med  200
                {
                    level4.Add(p);  //lägg till personobjektet i level4 listan
                    numberOfEmployees++;    //plussa på antal säljare med 1
                }
                else        //om inget av ovanstående stämmer, skriv ut ogiltigt val
                {
                    Console.WriteLine("Ogiltigt val");
                }
                    
            }

            

        }
        
        //funktion som skriver ut dem anställda
        public void printPersons()
        {
            Console.WriteLine("Namn: "+"\t"+"Personnummer: "+"\t"+"Distrikt: "+"\t"+"Antal: ");     //skriver ut rubriken
            int antal = level1.Count;   //antal är antalet som finns i listan
            
                foreach (Person p in level1)    //foreach loop som kollar för varje person p i nivå1
                {

                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);    //printar ut namn,id,distrikt och antal

                }
                if (level1.Count == 0)      //om nivå1 listan innehåller 0 så printa en tom sträng
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine(antal + " säljare har nått nivå 1: 0-49 artiklar");       //skriver ut antalet säljare som nått nivå1
                }



                foreach (Person p in level2)     //foreach loop som kollar för varje person p i nivå2
            {
                    antal = level2.Count;       //antalet som finns i listan
                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);    //printar ut namn,id,distrikt och antal

            }

                if (level2.Count == 0)  //om nivå2 listan innehåller 0 så printa en tom sträng
            {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine(antal + " säljare har nått nivå 2: 50-99 artiklar");      //skriver ut antalet säljare som nått nivå3
            }
                foreach (Person p in level3)        //foreach loop som kollar för varje person p i nivå3
            {
                    antal = level3.Count;       //antalet som finns i listan
                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);    //printar ut namn,id,distrikt och antal

            }
                if (level3.Count == 0)      //om nivå3 listan innehåller 0 så printa en tom sträng
            {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine(antal + " säljare har nått nivå 3: 100-199 artiklar");    //skriver ut antalet säljare som nått nivå3
            }
                foreach (Person p in level4)
                {
                    antal = level4.Count;       //antalet som finns i listan
                    Console.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);    //printar ut namn,id,distrikt och antal

            }
                if (level4.Count == 0)      //om nivå4 listan innehåller 0 så printa en tom sträng
            {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine(antal + " säljare har nått nivå 4: över 199 artiklar");       //skriver ut antalet säljare som nått nivå4
            }
                
            


        }

        //funktion som sparar den analyserade datan till en txt fil
        public void SaveToFile()
        {
            
            StreamWriter file = new StreamWriter("Analys2.txt");        //streamwrite objekt och vad textfilen ska heta.

            file.WriteLine("Namn: " + "\t" + "Personnummer: " + "\t" + "Distrikt: " + "\t" + "Antal: ");    //skriver ut rubriken
            int antal = level1.Count;   //antalet som finns i listan

            foreach (Person p in level1)        //foreach loop som kollar för varje person p i nivå1
            {

                file.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);   //skriver till fil, namn,id,distrikt och antal

            }
            if (level1.Count == 0)      //om nivå1 listan innehåller 0 så printa en tom sträng
            {
                file.Write("");
            }
            else
            {
                file.WriteLine(antal + " säljare har nått nivå 1: 0-49 artiklar");
            }
            foreach (Person p in level2)        //foreach loop som kollar för varje person p i nivå2
            {
                antal = level2.Count;
                file.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);   //skriver till fil, namn,id,distrikt och antal

            }

            if (level2.Count == 0)      //om nivå2 listan innehåller 0 så printa en tom sträng
            {
                file.Write("");
            }
            else
            {
                file.WriteLine(antal + " säljare har nått nivå 2: 50-99 artiklar");
            }
            foreach (Person p in level3)        //foreach loop som kollar för varje person p i nivå3
            {
                antal = level3.Count;       //antalet som finns i listan
                file.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);   //skriver till fil, namn,id,distrikt och antal

            }
            if (level3.Count == 0)      //om nivå3 listan innehåller 0 så printa en tom sträng
            {
                file.Write("");
            }
            else
            {
                file.WriteLine(antal + " säljare har nått nivå 3: 100-199 artiklar");
            }
            foreach (Person p in level4)        //foreach loop som kollar för varje person p i nivå4
            {
                antal = level4.Count;       //antalet som finns i listan
                file.WriteLine(p.name + "\t" + p.id + "\t" + p.district + "\t" + p.quantity);   //skriver till fil, namn,id,distrikt och antal

            }
            if (level4.Count == 0)      //om nivå4 listan innehåller 0 så printa en tom sträng
            {
                file.Write("");
            }
            else
            {
                file.WriteLine(antal + " säljare har nått nivå 4: över 199 artiklar");
            }
            file.Close();       //stänger filen



        }
    }
}
