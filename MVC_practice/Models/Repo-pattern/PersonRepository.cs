
using System;

namespace MVC_practice.Models.Repo_pattern
{
    public class PersonRepository : IpersonRepository
    {
        List<Person> people = new List<Person>();
        public void AddPerson(Person person)
        {
             people.Add(person);
        }

        public void DeletPerson(int id)
        {
            foreach (var person in people) 
            {
                if (person.Id == id)
                {
                    people.Remove(person);
                }
            
            
            }
        }
        public IList<Person> GetAll()
        {
            return people.ToList();
        }
    }
}
