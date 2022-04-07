using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public interface IPersonRepo
    {
        List<Person> GetAllPersons();
        Person GetPersonById(int Id);
        Person AddPerson(Person person);
        void DeletePerson(Person person);
        Person UpdatePerson(Person person);
        
        List<string> AllInterest(int Id);
        List<string> AllLinks(int Id);
        Person NewInterest(int Id);
        Person NewWebsite(int Id);

        //void Save();

    }
}
