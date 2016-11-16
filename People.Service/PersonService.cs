using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Service
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetPerson()
        {
            throw new NotImplementedException();
        }
    }
}