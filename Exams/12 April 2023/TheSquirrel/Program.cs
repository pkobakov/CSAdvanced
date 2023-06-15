using System;
using System.Collections.Generic;
using System.Linq;
namespace TheSquirrel
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int hazelnuts = 0;
			int n = int.Parse(Console.ReadLine());
			char[,] field = new char[n, n];

			string[] directions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

			int squirrelRow = 0;
			int squirrelCol = 0;

			int lastRow = 0;
			int lastCol = 0;

			bool trapped = false;
			bool outOfField = false;

			for (int row = 0; row < n; row++)
			{ 
				char[] currentRow = Console.ReadLine().ToCharArray();

				for (int col = 0; col < n; col++)
				{
					field[row, col] = currentRow[col];
				}
			}

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
					if (field[row, col] == 's')
					{
						squirrelRow = row;
						squirrelCol = col;
					}
                }
            }

			for (int i = 0; i < directions.Length; i++)
			{
				field[squirrelRow, squirrelCol] = 's';

				string direction = directions[i];

				lastRow = squirrelRow;
				lastCol = squirrelCol;

				squirrelRow = MoveRow(direction, squirrelRow);
				squirrelCol = MoveCol(direction, squirrelCol);

				if (IsOut(n, squirrelRow, squirrelCol))
				{
					
                    field[lastRow, lastCol] = '*';
					outOfField = true;
                    Console.WriteLine("The squirrel is out of the field.");
                    break;
                }

				if (field[squirrelRow, squirrelCol] == 'h')
				{
					hazelnuts++;

					if (hazelnuts == 3) 
					{
                        break;
					}
				}

				if (field[squirrelRow, squirrelCol] == 't') 
				{
					trapped = true;
                    Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                    field[squirrelRow, squirrelCol] = '*';
                    break;
				}

                field[squirrelRow, squirrelCol] = '*';
            }

            if (hazelnuts == 3 )
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
            }

			else 
			{
				if (!trapped && !outOfField) 
				{ 
                    Console.WriteLine("There are more hazelnuts to collect.");
				
				}
            }

            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");

            //Print field:

            //for (int row = 0; row < n; row++)
			//{

			//	for (int col = 0; col < n; col++)
			//	{
			//		Console.Write(field[row, col]);
			//	}

			//	Console.WriteLine();
			//}
		}
		private static int MoveRow(string direction, int row)
		{
			if (direction == "up") 
			{
				return row -= 1;
			}

			if (direction == "down") 
			{
				return row += 1;
			}

			return row;
		}

        private static int MoveCol(string direction, int col)
        {
            if (direction == "left")
            {
                return col -= 1;
            }

            if (direction == "right")
            {
                return col += 1;
            }

            return col;
        }
		private static bool IsOut(int range, int row, int col) 
		{
			if (row < 0 || row >= range||
				col < 0 || col >= range) 
			{
				return true; ;
			}

			return false;
		}

    }
}