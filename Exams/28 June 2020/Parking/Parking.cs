using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking
    {
        List<Car> data;
        private string type;
        private int capacity;
        public Parking(string type, int capacity) 
        {
           this.data = new List<Car>(); 
            this.Type = type;
            this.Capacity = capacity;
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.data.Count; } }
        public void Add(Car car) 
        {
            if (this.Count < this.Capacity) 
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model) 
        {
            if (this.data.Any(c => c.Manufacturer == manufacturer && c.Model == model)) 
            {
                return this.data.Remove(this.data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model));
            }
            
            return false;
        }
        public Car GetLatestCar() 
        {
            if (!this.data.Any())
            {
                return null;
            }

            return this.data.OrderByDescending(c => c.Year).FirstOrDefault();
          
        }
        public Car GetCar(string manufacturer, string model) 
        {
            if (!this.data.Any(c => c.Manufacturer == manufacturer && c.Model == model)) 
            {
                return null;
            }

            return this.data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
        }
        public string GetStatistics() 
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (Car car in this.data) 
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
