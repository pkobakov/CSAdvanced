using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApocalypsePreparation
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<int> textiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());	
			Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
			Dictionary<string, int> counter = new Dictionary<string, int>() 
			{
				{"Patch", 0 },
				{"Bandage", 0 }, 
				{"MedKit", 0 }

			};

			while (textiles.Any() && medicaments.Any()) 
			{
                
                int sum = textiles.Peek() + medicaments.Peek();

				if (sum == 30)
				{
                    textiles.Dequeue();
                    medicaments.Pop();
                    counter["Patch"]++;continue;
				}

				else if (sum == 40)
				{
                    textiles.Dequeue();
                    medicaments.Pop();
                    counter["Bandage"]++;continue;
				}

				else if (sum == 100) 
				{
                    textiles.Dequeue();
                    medicaments.Pop();
                    counter["MedKit"]++;continue;
				}

				if (sum > 100)
				{
					textiles.Dequeue();
					medicaments.Pop();
					medicaments.Push(medicaments.Pop() + (sum-100));
					counter["MedKit"]++; continue;

                }

				else 
				{
				    textiles.Dequeue() ;
					int value = medicaments.Pop();
					value += 10;
					medicaments.Push(value); continue;
				}				
			}

			StringBuilder stringBuilder = new StringBuilder();

			if (!textiles.Any() && !medicaments.Any())
			{
				stringBuilder.AppendLine("Textiles and medicaments are both empty.");
			}

			else if (!textiles.Any()) 
			{
				stringBuilder.AppendLine("Textiles are empty.");
			}
			else if (!medicaments.Any()) 
			{
				stringBuilder.AppendLine("Medicaments are empty.");
			}

			foreach (var item in counter.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
			stringBuilder.AppendLine($"{item.Key} - {item.Value}");
			}

			if (medicaments.Any()){ stringBuilder.AppendLine($"Medicaments left: {string.Join(", ", medicaments)}"); }
			if (textiles.Any()) { stringBuilder.AppendLine($"Textiles left: {string.Join(", ", textiles)}"); }


            Console.WriteLine(	stringBuilder.ToString().TrimEnd());
        }
	}
}