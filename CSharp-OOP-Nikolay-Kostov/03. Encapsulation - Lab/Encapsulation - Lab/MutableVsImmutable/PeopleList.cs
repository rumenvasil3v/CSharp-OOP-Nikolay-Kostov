using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableVsImmutable
{
    public class PeopleList
    {
        private List<Person> people;

        public PeopleList(List<Person> people)
        {
            this.People = people;
        }

        public IReadOnlyCollection<Person> People 
        {
            get { return this.people.AsReadOnly(); }
            private set
            {
                this.people = (List<Person>)value;
            }
        }

        //public void AddPerson(Person person)
        //{
        //    this.people.Add(person);
        //}

        public void ChangePeopleList(List<Person> newList)
        {
            this.People = newList;
        }
    }
}
