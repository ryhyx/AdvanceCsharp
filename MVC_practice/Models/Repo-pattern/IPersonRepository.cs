using System.Collections.Generic;

namespace MVC_practice.Models.Repo_pattern
{
    public interface IpersonRepository
    {
        public void AddPerson(Person person);
        public void DeletPerson(int id );
        IList<Person> GetAll();
    }
}
