using System;
using System.Collections.Generic;
using System.Linq;
namespace TruffleHunter
{
    public class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			string[,] forest = new string[n,n];
			int blackTruffels = 0;
			int summerTruffels = 0;
			int whiteTruffels = 0;
			int trufflesEaten = 0;

			//Drawing the forest:

			for (int row = 0; row < n; row++)
			{
				string [] line = Console.ReadLine().Split().ToArray();
				
				for (int col = 0; col < n; col++)
				{
					forest[row, col] = line[col];
				}
			}
            

			int myRow = 0;
			int myCol = 0;

			int boarRow = 0;
			int boarCol = 0;	

			string command = Console.ReadLine();

			while ( command != "Stop the hunt" )
			{
				string[] commandArgs = command.Split().ToArray();
				string commandType = commandArgs[0];
				
				

				if (commandType == "Collect")
				{
				    int row = int.Parse(commandArgs[1]);
				    int col = int.Parse(commandArgs[2]);
				    myRow = row;
				    myCol = col;

					

					if (forest[myRow, myCol] == "-" || IsOut(n, row, col)) 
					{
                    }

					if (forest[myRow, myCol] == "B")
					{
						forest[myRow, myCol] = "-";
						blackTruffels++;
					}

                    if (forest[myRow, myCol] == "S")
                    {
                        forest[myRow, myCol] = "-";
                        summerTruffels++;
                    }

                    if (forest[myRow, myCol] == "W")
                    {
                        forest[myRow, myCol] = "-";
                        whiteTruffels++;
                    }


                }

				if (commandType == "Wild_Boar")
				{
					boarRow = int.Parse(commandArgs[1]);
					boarCol = int.Parse(commandArgs[2]);
					string direction = commandArgs[3];

					if (direction == "up") 
					{
						trufflesEaten += CheckPositition(forest, boarRow, boarCol);
						forest[boarRow, boarCol] = "-";

						while (boarRow - 2 >= 0) 
						{
                           trufflesEaten += CheckPositition(forest, boarRow -= 2, boarCol);
                           forest[boarRow, boarCol] = "-";
						
						}
                    }


                    if (direction == "down")
                    {
                        trufflesEaten += CheckPositition(forest, boarRow, boarCol);
                        forest[boarRow, boarCol] = "-";

						while (boarRow + 2 < n) 
						{
                            trufflesEaten += CheckPositition(forest, boarRow += 2, boarCol);
                            forest[boarRow, boarCol] = "-";
						
						}
                    }

                    if (direction == "right")
                    {

                        trufflesEaten += CheckPositition(forest, boarRow, boarCol);
                        forest[boarRow, boarCol] = "-";

						while (boarCol + 2 < n) 
						{
                           trufflesEaten += CheckPositition(forest, boarRow, boarCol += 2);
                           forest[boarRow, boarCol] = "-";
						
						}
                    }

                    if (direction == "left")
                    {
                        trufflesEaten += CheckPositition(forest, boarRow, boarCol);
                        forest[boarRow, boarCol] = "-";

						while (boarCol - 2 >= 0) 
						{
                            trufflesEaten += CheckPositition(forest, boarRow, boarCol -= 2); ;
                            forest[boarRow, boarCol] = "-";
						
						}
                    }
                }


			   command = Console.ReadLine();
			}

            Console.WriteLine($"Peter manages to harvest {blackTruffels} black, {summerTruffels} summer, and {whiteTruffels} white truffles.");
			Console.WriteLine($"The wild boar has eaten {trufflesEaten} truffles.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{forest[row, col]} ");

                }
                Console.WriteLine();
            }
        }

		private static bool IsOut(int n, int row, int col) 
		{ 
		   if ( row < 0 || row > n || col < 0 || col > n )
		   { 
			  return true;
		   }

		   return false;
		}

		private static int CheckPositition(string[,] matrix, int row, int col) 
		{
			int trufflesCount = 0;
			if (matrix[row, col] == "B")
			{
				return trufflesCount += 1;
			}
            if (matrix[row, col] == "W")
            {
                return trufflesCount += 1;
            }
            if (matrix[row, col] == "S")
            {
                return trufflesCount += 1;
            }

			return trufflesCount;

        }
    }
}