using System;
using System.Collections.Generic;
namespace MealPlan
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<string> meals = new Queue<string>(Console.ReadLine().Split());
			Stack<int> calories = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

			Dictionary<string, int> mealsCalories = new Dictionary<string, int>()
			{
				{ "salad", 350 },
				{ "soup", 490 },
				{ "pasta", 680 },
				{ "steak", 790 }
			   
			};


			int mealsEaten = 0;

			while (calories.Count > 0 && meals.Count > 0)
			{ 
			    string currentMeal = meals.Dequeue();
				int dailyCalories = calories.Pop();

				if (dailyCalories == 0) 
				{
					calories.Pop();
				}

				else if (dailyCalories - mealsCalories[currentMeal] < 0) 
				{
					if (calories.Count == 0) 
					{
						mealsEaten++;  break;
					}
					int caloriesLeft = dailyCalories - mealsCalories[currentMeal];					
					dailyCalories = Math.Abs((calories.Pop()) + caloriesLeft);
					calories.Push(dailyCalories);
				}

				else if(dailyCalories > mealsCalories[currentMeal]) 
				{
					dailyCalories -= mealsCalories[currentMeal];
					calories.Push(dailyCalories);
				}
				mealsEaten++;
			}

			if (meals.Count == 0)
			{
                Console.WriteLine($"John had {mealsEaten} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }

			else
			{
                Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
				Console.WriteLine($"Meals left: {string.Join(", ",meals)}.");
            }
        }
    }
}