using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.Interface
{
    public interface IPersonRepopsitory
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatePerson);

        void DeletePerson(string lastName);

        void UpdatePeople(IEnumerable<Person> updatePeople);
    }
}