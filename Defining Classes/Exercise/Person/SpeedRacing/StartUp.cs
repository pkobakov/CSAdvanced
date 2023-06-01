namespace SpeedRacing
{
	using System;
    using System.Globalization;
    using System.Transactions;

    public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<Car> garage = new List<Car>();	
			

			for (int i = 0; i < n; i++)
			{
				string [] command = Console.ReadLine().Split().ToArray();
				string model = command[0];
				double fuelAmount = double.Parse(command[1]);
				double fuelConsumption = double.Parse(command[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
				garage.Add(car);
			}

			string action = Console.ReadLine();
			while (action != "End")
			{
				string[] commandArgs = action.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
				string actionType = commandArgs[0];
				string model = commandArgs[1];
				int distance = int.Parse(commandArgs[2]);

				Car currentCar = garage.FirstOrDefault(c => c.Model == model);
				currentCar.Drive(currentCar.Model, distance);
				action = Console.ReadLine();
			}

			foreach (var car in garage)
			{
                Console.WriteLine(car.ToString());
            }
        }
	}
}