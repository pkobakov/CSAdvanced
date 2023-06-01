using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer) 
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;

        }
        
        public string Model { get { return model; } private set { model = value; } }   
        public double FuelAmount { get { return fuelAmount; } private set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } private set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get; private set; }

        public void Drive(string model , int amountOfKm)
        {  
            double fuelNeeded =  FuelConsumptionPerKilometer * amountOfKm;
           if (fuelNeeded <= this.FuelAmount)
           {
                this.TravelledDistance += amountOfKm;
                this.FuelAmount -= fuelNeeded;
           }

           else 
           {
                Console.WriteLine("Insufficient fuel for the drive");
           }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}
