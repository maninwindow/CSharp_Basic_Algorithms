using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Service
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPerson();
    }
}