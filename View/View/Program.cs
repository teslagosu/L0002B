using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Program view = new Program(); //objekt av Program klassen.
            PersonController pc = new PersonController(view); //objekt av personcontroller klassen

            //funktioner som k�r programmet.
            pc.createNewSalesPerson();
            pc.printPersons();
            pc.SaveToFile();


        }
    }
}
