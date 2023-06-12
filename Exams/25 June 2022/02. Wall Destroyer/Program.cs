using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace _02._Wall_Destroyer
{
	public class Program
	{
		public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int vaskoRow = 0;
            int vaskoCol = 0;
            int lastRow = 0;
            int lastCol = 0;
            int holes = 0;
            int rods = 0;
            bool isElectriced = false; ;

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'V')
                    {
                        vaskoRow = row;
                        vaskoCol = col;
                        holes += 1;
                        matrix[vaskoRow, vaskoCol] = '*';
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                lastRow = vaskoRow;
                lastCol = vaskoCol;
                vaskoRow = MoveRow(command, vaskoRow);
                vaskoCol = MoveCol(command, vaskoCol);
                
                if (!IsInside(n, vaskoRow, vaskoCol))
                {
                    vaskoRow = lastRow;
                    vaskoCol = lastCol;
         
                }

                else 
                { 
 
                    if (matrix[vaskoRow, vaskoCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{vaskoRow}, {vaskoCol}]!");
                    }

                   else if (matrix[vaskoRow, vaskoCol] == 'R')
                   {
                       vaskoRow = lastRow; 
                       vaskoCol = lastCol;
                       
                       rods += 1;
                       Console.WriteLine("Vanko hit a rod!");

                   }


                   else if (matrix[vaskoRow, vaskoCol] == '-')
                   {
                       matrix[vaskoRow, vaskoCol] = '*';
                       holes += 1;

                   }

                   else if (matrix[vaskoRow, vaskoCol] == 'C')
                   {
                       isElectriced = true;
                       matrix[vaskoRow, vaskoCol] = 'E';
                       holes += 1;
                       break;
                   }
                }

                command = Console.ReadLine();
            }

            if (isElectriced) 
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                matrix[vaskoRow, vaskoCol] = 'V';
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {rods} rod(s).");
            }


            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsInside(int n, int vaskoRow, int vaskoCol)
        {
            if (vaskoRow < 0 || vaskoRow > n ||
                                vaskoCol < 0 || vaskoCol > n)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

		private static int MoveRow(string command, int row) 
		{
            if (command == "down")
            {
                row += 1;
            }

            if (command == "up")
            {
                row -= 1;
            }
			
            return row;
		} 

		private static int MoveCol (string command, int col)
		{
            if (command == "right") 
            {
                col += 1;
            }

            if (command == "left") 
            {
               col -= 1;
            }

			return col;	
		}
    }
}
