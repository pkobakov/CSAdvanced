using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        //private string name;
        //private int capacity;
        //private List<Child> registry;
        public Kindergarten(string name, int capacity) 
        {
           this.Name = name;
           this.Capacity = capacity;
           this.Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public bool AddChild(Child child) 
        {
            if (this.Registry.Count >= this.Capacity)
            {
                return false;
            }

            this.Registry.Add(child);
            return true;
        
        }

        public int ChildrenCount { get { return this.Registry.Count; } }

        public bool RemoveChild(string name) 
        {
            string[] fullname = name.Split().ToArray();

            string firstName = fullname[0];
            string lastName = fullname[1];

            var child = this.Registry.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (child != null) 
            {
                this.Registry.Remove(child);
                return true;
            }

            return false;
        }
        public Child GetChild(string childFullName) 
        {
            string[] fullname = childFullName.Split().ToArray();

            string firstName = fullname[0];
            string lastName = fullname[1];

            var child = this.Registry.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            if (child == null) { return null; }

            return child;

        }

        public string RegistryReport() 
        {
           StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Registered children in {this.Name}:");

            foreach (var child in this.Registry.OrderByDescending(x => x.Age)
                                               .ThenBy(x => x.LastName)
                                               .ThenBy(x => x.FirstName))
            {
                stringBuilder.AppendLine(child.ToString());
            }
            return stringBuilder.ToString().TrimEnd();
        }


    }
}
