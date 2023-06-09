using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic
{
    public class Pet
    {
        private string name;
        private int age;
        private string owner;

        public Pet(string name,  int age, string owner)
        {
            this.Name = name;
            this.Age = age; 
            this.Owner = owner; 
        }

        public  string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Owner { get { return owner; } set { owner = value; } }

        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Owner: {this.Owner}";
        }
    }
}
