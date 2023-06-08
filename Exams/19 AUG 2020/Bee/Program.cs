using System;
using System.Linq;
using System.Collections.Generic;
namespace Bee
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			char[,] matrix = new char[n, n] ;
			int flowersCount = 0 ;

			for (int row = 0; row < n; row++)
			{
				char[] currentRow = Console.ReadLine().ToCharArray();
				for (int col = 0; col < n; col++)
				{
					matrix[row, col] = currentRow[col];
					
                }

            }

			int beeRow = 0;
			int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
					if (matrix[row, col] == 'B' )
					{
						beeRow = row;
						beeCol = col;
					}
                }
            }

			string command = Console.ReadLine();

			while (command != "End")
			{
                matrix[beeRow, beeCol] = '.';
                beeRow = MoveRow(command, beeRow);
				beeCol = MoveCol(command, beeCol);

				if (!IsInside(beeRow, beeCol, n, n))
				{
                    Console.WriteLine("The bee got lost!");
                    break;
				}

				if (matrix[beeRow, beeCol] == 'f')
				{
					
					flowersCount++;
				}

                if (matrix[beeRow, beeCol] == 'O')
                {
					matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(command, beeRow);
                    beeCol = MoveCol(command, beeCol);
                    if (!IsInside(beeRow, beeCol, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        flowersCount++;
                    }
                }
                matrix[beeRow, beeCol] = 'B';
                command = Console.ReadLine();	
			}

			string result = flowersCount < 5 ? $"The bee couldn't pollinate the flowers, she needed {5-flowersCount} flowers more"
				                             : $"Great job, the bee managed to pollinate {flowersCount} flowers!";


            Console.WriteLine(result);

            for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
                    Console.Write(matrix[row, col]);
                }

				Console.WriteLine();
			}
		}

		public static int MoveRow(string action, int row) 
		{
			if (action == "up") 
			{
				return row - 1;
			}

			if (action == "down")
			{
				return row + 1;
			}

			return row;
		}

        public static int MoveCol(string action, int col)
        {
            if (action == "left")
            {
                return col - 1;
            }

            if (action == "right")
            {
				return col + 1; ;
            }

            return col;
        }

		public static bool IsInside(int row, int col, int rows, int cols)
		{
			if (row < 0 || row >= rows )
			{
				return false;
			}

			if (col < 0 || col >= cols)
			{
				return false;
			}

			return true;
		}

    }
}