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
        Person AddPerson(Person person); //NYI
        void DeletePerson(Person person); //NYI
        Person UpdatePerson(Person person); //NYI
        
        List<string> AllInterest(int Id);
        List<string> AllLinks(int Id);
        

        //void Save();

    }
}
