using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Person
    {
        //instansvariabler med getters och setters
        public string name { get; set; }
        public string id { get; set; }
        public string district { get; set; }
        public int quantity { get; set; }
        
        //konstruktor
        public Person(string name, string id, string district, int quantity)
        {
            this.name = name;
            this.id = id;
            this.district = district;
            this.quantity = quantity;
        }

    }
}
