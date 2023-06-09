using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private int capacity;
        private List<Pet> data;

        public Clinic( int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return data.Count; } } 

        public void Add(Pet pet) 
        {
            if (this.Capacity > this.Count)
            {
                this.data.Add(pet);
            }
        }

        public bool Remove (string name)
        {
            if (this.data.Any())
            {
                Pet pet = this.data.FirstOrDefault(p => p.Name == name);
                this.data.Remove(pet);
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner) 
        {
            if (this.data.Any())
            {
               return  this.data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
            }

            return null;
        }

        public Pet GetOldestPet() 
        {
            if (this.data.Any())
            {
                return this.data.OrderByDescending(p => p.Age).FirstOrDefault();
            }

            return null;
        }

        public string GetStatistics() 
        {
            if (!this.data.Any())
            {
                return null; 
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in this.data) 
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString();   
        }


    }
}
