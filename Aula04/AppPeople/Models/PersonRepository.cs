using System.Collections.Generic;

namespace AppPeople.Models
{
    public class PersonRepository
    {
        public List<Person> people = new List<Person>();

        public void create(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetAll()
        {
            return people;
        }

        public void GetById(int id)
        {

        }

        public void Update()
        {
            
        }

        public void Delete()
        {
            
        }
    }
}