using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public ICollection<Person> People => this.people.ToList();
        public Person GetOldestMember()
        {
            return this.people.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
