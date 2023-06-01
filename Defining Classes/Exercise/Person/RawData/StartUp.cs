namespace RawData
{
    using RawData.Utilities;
    using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{

			int n = int.Parse(Console.ReadLine());
			List<Car> garage = new List<Car>();

			for (int i = 0; i < n; i++)
			{
				string[] carDetails = Console.ReadLine().Split().ToArray();
				string model = carDetails[0];
				int engineSpeed = int.Parse(carDetails[1]);
				int enginePower = int.Parse(carDetails[2]);

				Engine engine = new Engine(engineSpeed, enginePower);

				int cargoWeight = int.Parse(carDetails[3]);
				string cargoType = carDetails[4];

				Cargo cargo = new Cargo(cargoType, cargoWeight);

				double pressure1 = double.Parse(carDetails[5]);
				int year1 = int.Parse(carDetails[6]);
				double pressure2 = double.Parse(carDetails[7]);
				int year2 = int.Parse(carDetails[8]);
				double pressure3 = double.Parse(carDetails[9]);
				int year3 = int.Parse(carDetails[10]);
				double pressure4 = double.Parse(carDetails[11]);
				int year4 = int.Parse(carDetails[12]);



				Tire[] tires = new Tire[]
				{
				   new Tire(pressure1,year1 ),
				   new Tire(pressure2, year2),
				   new Tire(pressure3, year3),
				   new Tire(pressure4, year4)
				};

				Car currCar = new Car(model, engine, cargo, tires);

				garage.Add(currCar);

			}

			string currCargoType = Console.ReadLine();

			ICollection<Car> sorted = currCargoType switch
			{
			   nameof(Constants.fragile) => garage.Where(c => c.Cargo.Type == currCargoType &&
													   c.Tires.Any(t => t.Pressure < 1)).ToList(),
			   nameof(Constants.flammable) => sorted = garage.Where(c => c.Cargo.Type == currCargoType &&
														  c.Engine.Power > 250).ToList()
			};

			foreach (Car car in sorted) 
			{
                Console.WriteLine(car.Model);
            }
		}
	}
}