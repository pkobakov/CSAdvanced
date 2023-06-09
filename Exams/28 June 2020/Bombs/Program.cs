using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace Bombs
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
			Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
			Dictionary<string, int> bombs = new Dictionary<string, int>() 
			{
				{ "Datura Bombs", 0},
                { "Cherry Bombs", 0},
                { "Smoke Decoy Bombs", 0}
			};

			

			int datura = 40;
			int cherry = 60;
			int smokeDecoy = 120;
			bool  bombPouchIsFull = false; 

			int daturaCount = 0;
			int cherryCount = 0;
			int smokeDecoyCount = 0;


			while ((effects.Any() && casings.Any())) 
			{
				int sum = effects.Peek() + casings.Peek();

                if ( bombs.Values.All(b => b >= 3 ))
                {
                    bombPouchIsFull = true; break;
                }

                if ( sum == datura) 
				{
					effects.Dequeue();
					casings.Pop();
					bombs["Datura Bombs"]++; continue;
				}

				if (sum == cherry) 
				{
                    effects.Dequeue();
                    casings.Pop();
					bombs["Cherry Bombs"]++; continue;
                }

				if(sum == smokeDecoy) 
				{
                    effects.Dequeue();
                    casings.Pop();
					bombs["Smoke Decoy Bombs"]++; continue;	
                }

				else
				{
					int casingForDecrease = casings.Pop();
					casingForDecrease -= 5;
					casings.Push(casingForDecrease); continue;
				}


			}

			

			StringBuilder sb = new StringBuilder();
			string conclusion = bombPouchIsFull ? "Bene! You have successfully filled the bomb pouch!" : "You don't have enough materials to fill the bomb pouch.";
			sb.AppendLine(conclusion);
			string effectsLeft = effects.Count == 0 ? "Bomb Effects: empty" : $"Bomb Effects: {string.Join(", ", effects)}";
            sb.AppendLine(effectsLeft);
			string casingsLeft = casings.Count == 0 ? "Bomb Casings: empty" : $"Bomb Casings: {string.Join(", ", casings)}";
			sb.AppendLine(casingsLeft);

			foreach (var bomb in bombs.OrderBy(b => b.Key)) 
			{
			
			    sb.AppendLine($"{bomb.Key}: {bomb.Value}");
			
			}
			

            Console.WriteLine(sb.ToString().Trim()	);
        }
	}
}