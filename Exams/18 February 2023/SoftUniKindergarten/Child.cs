using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKindergarten
{
    public class Child
    {
        private string firstName;
        private string lastName;    
        private int age;
        private string parentName;
        private string contactNumber;

        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.ParentName = parentName;
            this.ContactNumber = contactNumber;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string ParentName { get { return parentName; } set { parentName = value; } }
        public string ContactNumber { get { return contactNumber; } set { contactNumber = value; } }

        public override string ToString() 
        { 
            return $"Child: {this.FirstName} {this.LastName}, Age: {this.Age}, Contact info: {this.ParentName} - {this.ContactNumber}";
        }
    }
}
