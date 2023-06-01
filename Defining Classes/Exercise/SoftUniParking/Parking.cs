using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;
        public Parking(int capacity) 
        {
           this.cars = new List<Car>();
           this.Capacity = capacity;

        }

        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get => this.cars.Count; }

        public string AddCar(Car car) 
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }



            if (this.capacity <= this.cars.Count)
            {
                return "Parking is full!";
            }

            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            
        }

        public string RemoveCar(string RegistrationNumber) 
        {
            if (!this.cars.Any(c => c.RegistrationNumber == RegistrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            else 
            {
               Car car = this.cars.Find(c => c.RegistrationNumber == RegistrationNumber);
               this.cars.Remove(car); 
               return $"Successfully removed {car.RegistrationNumber}";
            }
        }

        public Car GetCar(string RegistrationNumber) 
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);
            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers) 
        {
            foreach (string regNum in registrationNumbers)
            {
                while (this.cars.Any(c => c.RegistrationNumber == regNum))
                {
                    Car currCar = this.cars.FirstOrDefault(c => c.RegistrationNumber == regNum);
                    this.cars.Remove(currCar);
                }
            }

        }
    }
}
