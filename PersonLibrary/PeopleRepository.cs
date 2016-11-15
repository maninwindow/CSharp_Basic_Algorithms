using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PeopleRepository
    {
        public Person[] GetPeple { get; set; }

        public Person GetPerson(string lastName)
        {
            Person person = new Person();
            return person;
        }
    }
}