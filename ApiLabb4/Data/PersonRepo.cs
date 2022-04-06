using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public class PersonRepo : IPersonRepo
    {
        private ApiLabb4Context _Labb4Context;
        public PersonRepo(ApiLabb4Context labb4Context)
        {
            _Labb4Context = labb4Context;
        }
        public void DeletePerson(Person person)
        {
            _Labb4Context.Persons.Remove(person);
            _Labb4Context.SaveChanges();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _Labb4Context.Persons.ToList();
        }

        public Person GetPersonById(int Id)
        {
            return _Labb4Context.Persons.FirstOrDefault(p => p.personId == Id);
        }

        public Person AddPerson(Person newPerson)
        {
            _Labb4Context.Persons.Add(newPerson);
            _Labb4Context.SaveChanges();
            return newPerson;
        }

        public Person UpdatePerson(Person person)
        {
            var updatedPerson = _Labb4Context.Persons.Find(person.personId);
            if(updatedPerson != null)
            {
                updatedPerson.Name = person.Name;
                updatedPerson.Phonenumber = person.Phonenumber;
                updatedPerson.Interests = person.Interests;
                _Labb4Context.Persons.Update(updatedPerson);
                _Labb4Context.SaveChanges();
            }
            return person;
        }
    }
}
