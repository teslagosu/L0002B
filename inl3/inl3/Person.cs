using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inl3
{
    class Person
    {
        //instansvariabler med getters och setters.
        public string firstName { get; set; }
        public string lastName  { get; set; }
        public string ssn { get; set; }

        //konstruktor
        public Person(string firstName, string lastName, string ssn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
        }
    }
}
