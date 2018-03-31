using System.Collections.Generic;

namespace Oop3.Contracts
{
    public class Kingdom
    {
        public List<Person> PeopleOfKingdom { get; private set; }

        public Kingdom()
        {
            PeopleOfKingdom = new List<Person>();
        }

        public Kingdom(List<Person> people)
        {
            PeopleOfKingdom = people ?? new List<Person>();
        }

        //public void AddPerson(Person person)
        //{
        //    PeopleOfKingdom.Add(person);
        //}

        //public void RemovePerson(Person person)
        //{
        //    PeopleOfKingdom.Remove(person);
        //}
    }
}