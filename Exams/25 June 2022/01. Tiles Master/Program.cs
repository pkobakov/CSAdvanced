using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Dictionary<string, int> locationAreaNeeded = new Dictionary<string, int>() 
			{
				{ "Sink", 40},
				{ "Oven", 50},
				{ "Countertop", 60 },
				{ "Wall", 70}
			};

			int floorTiles = 0;
			int counterTopTiles = 0;
			int ovenTiles = 0;
			int sinkTiles = 0;
			int wallTiles = 0;

			Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
			Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


			while (whiteTiles.Count > 0 && greyTiles.Count > 0) 
			{ 
			    int currentTilesSum = 0;
				
				if (greyTiles.Peek() == whiteTiles.Peek()) 
				{
					currentTilesSum = greyTiles.Peek() + whiteTiles.Peek();


                    if (locationAreaNeeded.Values.Contains(currentTilesSum))
					{
						greyTiles.Dequeue();
						whiteTiles.Pop();

						int location = currentTilesSum;

						switch (location) 
						{
							case 40 : sinkTiles ++; break;
							case 50: ovenTiles ++; break;
							case 60: counterTopTiles ++; break;
							case 70: wallTiles ++; break;
						}
					}

					else
					{
						greyTiles.Dequeue();
						whiteTiles.Pop();
						floorTiles++;
					}
				}

				else
				{
					int tileToDecrease = whiteTiles.Pop();
					tileToDecrease/=2;
					whiteTiles.Push(tileToDecrease);

					int tileForTheBack = greyTiles.Dequeue();
					greyTiles.Reverse();
					greyTiles.Enqueue(tileForTheBack);
				}
			}

			Dictionary<string, int> decoratedLocations = new Dictionary<string, int>() 
			{
				{ "Floor", floorTiles},
				{ "Wall", wallTiles},
				{ "Oven", ovenTiles},
				{ "Sink", sinkTiles}, 
				{ "Countertop", counterTopTiles}    
			
			};

            StringBuilder stringBuilder = new StringBuilder();
		    string whiteTilesLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ",whiteTiles);
		    stringBuilder.AppendLine($"White tiles left: {whiteTilesLeft}");
		    string greyTilesLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);
			stringBuilder.AppendLine($"Grey tiles left: {greyTilesLeft}");

			foreach (var entry in decoratedLocations.Where(v => v.Value > 0).OrderByDescending(l => l.Value).ThenBy(k => k.Key)) 
			{
				stringBuilder.AppendLine($"{entry.Key}: {entry.Value}");
			}

			Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }
	}
}