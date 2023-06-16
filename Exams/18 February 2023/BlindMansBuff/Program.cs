using System;
using System.Collections.Generic;
using System.Linq;
namespace BlindMansBuff
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int rows = dimensions[0];
			int cols = dimensions[1];

			string[,] matrix = new string[rows, cols];

			int myRow = 0;
			int myCol = 0;

			int lastRow = 0;
			int lastCol = 0;

			int opponents = 0;
			int moves = 0;

			for (int row = 0; row < rows; row++)
			{
				string[] currentRow = Console.ReadLine().Split().ToArray();

				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = currentRow[col];
				}
			}

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					if (matrix[row, col] == "B")
					{
						myRow = row;
						myCol = col;
					}
				}
			}

			string command = Console.ReadLine();

			//"O" - furniture; "P" - opponent player (3)

			while (command != "Finish") 
			{
                matrix[myRow, myCol] = "-";
				lastRow = myRow;
				lastCol = myCol;

				myRow = MoveRow(command, myRow);
				myCol = MoveCol(command, myCol);

				if (IsOut(rows, myRow, cols, myCol))
				{
					myRow = lastRow; myCol = lastCol;
				}

				else if (matrix[myRow, myCol] == "O")
				{
					
                    myRow = lastRow; myCol = lastCol;
                }

                else if (matrix[myRow, myCol] == "P")
                {
				    moves++;
					opponents++;
					if (opponents == 3) { break; }
                }

				else if (matrix[myRow, myCol] == "-")
				{
					moves++;
				}

                matrix[myRow, myCol] = "B";	
                command = Console.ReadLine();
			}

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {opponents} Moves made: {moves}");

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

		private static bool IsOut(int rowsRange, int row, int colsRange, int col) 
		{
		   if ( row < 0 || row >= rowsRange ||
				col < 0 || col >= colsRange) 
		   { 
				return true;
		   }

		   return false;
		}
    }
}