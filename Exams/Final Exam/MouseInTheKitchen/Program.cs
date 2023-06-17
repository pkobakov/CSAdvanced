using System;
using System.Collections.Generic;
using System.Linq;

namespace MouseInTheKitchen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] cupboard = new char[rows, cols];

            int mouseRow = 0;
            int mouseCol = 0;

            int lastRow = 0;
            int lastCol = 0;

            int cheeseCount = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    cupboard[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {


                for (int col = 0; col < cols; col++)
                {
                    if (cupboard[row, col] == 'M')
                    {
                        mouseRow = row;
                        mouseCol = col;
                    }

                    if (cupboard[row, col] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "danger")
            {
                cupboard[mouseRow, mouseCol] = '*';

                lastRow = mouseRow;
                lastCol = mouseCol;

                mouseRow = MoveRow(command, mouseRow);
                mouseCol = MoveCol(command, mouseCol);

                if (IsOut(rows, mouseRow, cols, mouseCol))
                {
                    mouseRow = lastRow;
                    mouseCol = lastCol;
                    cupboard[mouseRow, mouseCol] = 'M';
                    Console.WriteLine("No more cheese for tonight!"); break;
                }

                else if (cupboard[mouseRow, mouseCol] == 'C')
                {
                    cheeseCount--;

                    if (cheeseCount == 0)
                    {
                        cupboard[mouseRow, mouseCol] = 'M';
                        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!"); break;
                    }
                }

                else if (cupboard[mouseRow, mouseCol] == '@')
                {
                    mouseRow = lastRow;
                    mouseCol = lastCol;

                }

                else if (cupboard[mouseRow, mouseCol] == 'T')
                {
                    //mouseRow = lastRow;
                    //mouseCol = lastCol;
                    cupboard[mouseRow, mouseCol] = 'M';
                    Console.WriteLine("Mouse is trapped!"); break;
                }


                command = Console.ReadLine();


            }

            if (command == "danger" && cheeseCount > 0)
            {
                cupboard[mouseRow, mouseCol] = '*';
                Console.WriteLine("Mouse will come back later!");

            }


            cupboard[mouseRow, mouseCol] = 'M';



            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(cupboard[row, col]);
                }

                Console.WriteLine();
            }


        }

        private static int MoveRow(string command, int row)
        {
            if (command == "up")
            {
                return row -= 1;
            }

            if (command == "down")
            {
                return row += 1;
            }

            return row;
        }

        private static int MoveCol(string command, int col)
        {
            if (command == "left")
            {
                return col -= 1;
            }

            if (command == "right")
            {
                return col += 1;
            }

            return col;
        }

        private static bool IsOut(int rows, int row, int cols, int col)
        {
            if (row < 0 || row >= rows ||
                col < 0 || col >= cols)
            {
                return true;
            }

            return false;
        }


    }
}