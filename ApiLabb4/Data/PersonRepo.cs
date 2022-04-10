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

        public List<Person> GetAllPersons()
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

        public List<string> AllInterest(int Id)
        {
            List<Interest> allInterest = _Labb4Context.Interests.ToList();
            List<string> allInterestTitels = new List<string>();
            foreach (var item in allInterest)
            {
                if (item.personId == Id)
                {
                    allInterestTitels.Add(item.Titel.ToString());
                }
            }
            return allInterestTitels;
            
        }
        public List<string> AllLinks(int Id)
        {
            List<string> websiteByIdstring = new List<string>();
            List<Interest> allInterest = _Labb4Context.Interests.ToList();
            List<Interest> allInterestbyCorrectID = new List<Interest>();
            foreach (var item in allInterest)
            {
                if (item.personId == Id)
                {
                    allInterestbyCorrectID.Add(item);
                }
            }
            List<WebSite> allWebSite = _Labb4Context.WebSites.ToList();
            var websiteById = (from i in allInterestbyCorrectID
                              join w in allWebSite on i.interestId equals w.interestId
                              select new { i, w = w.SiteURL }).ToList();
            foreach (var item in websiteById)
            {
                websiteByIdstring.Add(item.w.ToString());
            }
            
            return websiteByIdstring;
        }
        
    }
}
