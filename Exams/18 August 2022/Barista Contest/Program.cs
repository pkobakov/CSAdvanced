namespace ConsoleApp
{
	using System;
    using System.Transactions;
	using System.Collections.Generic;
	using System.Linq;
    using System.Text;

    public class Program
	{
		public static void Main(string[] args)
		{
			Dictionary<string, int> drinkQuantityNeeded = new Dictionary<string, int>() 
			{
				{ "Cortado", 50 },
				{ "Espresso", 75 },
				{ "Capuccino", 100 },
				{ "Americano", 150 },
				{ "Latte", 200}
			};

			Queue<int> coffeeQuantities = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
			Stack<int> milkQuantities = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

			Dictionary<string, int> allDrinksQuantities = new Dictionary<string, int>() 
			{
				{"Cortado", 0 },
				{"Espresso", 0 },
				{"Capuccino", 0 },
				{"Americano", 0 },
				{"Latte", 0 }    
			
			};

			while (coffeeQuantities.Count > 0 && milkQuantities.Count > 0) 
			{
				int currentCoffee = coffeeQuantities.Peek();
			    int currentMilk = milkQuantities.Peek();		

				if (drinkQuantityNeeded.Values.Contains(currentMilk+currentCoffee))
				{
					int quantitySum = currentCoffee + currentMilk;

					switch (quantitySum) 
					{
						case 50: allDrinksQuantities["Cortado"] ++; break;
                        case 75: allDrinksQuantities["Espresso"]++; break;
                        case 100: allDrinksQuantities["Capuccino"]++; break;
                        case 150: allDrinksQuantities["Americano"]++; break;
                        case 200: allDrinksQuantities["Latte"]++; break;

                    }
				    coffeeQuantities.Dequeue();
					milkQuantities.Pop();
				}

                else
                {
					coffeeQuantities.Dequeue();
					currentMilk = milkQuantities.Pop();
					currentMilk -= 5;
					milkQuantities.Push(currentMilk);
                }
            }

			if (milkQuantities.Count == 0 && coffeeQuantities.Count == 0) 
			{
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }

			if (milkQuantities.Any() || coffeeQuantities.Any())
			{
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

			StringBuilder stringBuilder = new StringBuilder();
			string coffeeLeft = coffeeQuantities.Count == 0 ? "none" : string.Join(", ", coffeeQuantities);
			stringBuilder.AppendLine($"Coffee left: {coffeeLeft}");
            string milkLeft = milkQuantities.Count == 0 ? "none" : string.Join(", ", milkQuantities);
            stringBuilder.AppendLine($"Milk left: {milkLeft}");

			foreach (var drink in allDrinksQuantities.Where(x => x.Value > 0).OrderBy(x => x.Value).ThenByDescending(x => x.Key)) 
			{
				
				stringBuilder.AppendLine($"{drink.Key}: {drink.Value}"); 
			   
			}

			Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }
	}
}