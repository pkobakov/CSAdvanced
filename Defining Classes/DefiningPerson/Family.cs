using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family; 

        public Family() 
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person person) 
        {
           this.family.Add(person);
        }

        public Person GetOldestMember() 
        {
            return this.family.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
