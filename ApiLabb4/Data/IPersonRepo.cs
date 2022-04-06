using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPersonById(int Id);
        Person AddPerson(Person person);
        void DeletePerson(Person person);
        Person UpdatePerson(Person person);
        //void Save();

    }
}
