using System;
namespace Snake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] territory = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    territory[row, col] = currentRow[col];
                }
            }

            int snakeRow = 0;
            int snakeCol = 0;

            int secondBurRow = 0;
            int secondBurCol = 0;
            int food = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (territory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }

                    if (territory[row, col] == 'B')
                    {
                        secondBurRow = row;
                        secondBurCol = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != string.Empty)
            {
                territory[snakeRow, snakeCol] = '.';
                snakeRow = MoveRow(command, snakeRow);
                snakeCol = MoveCol(command, snakeCol);

                if (!IsInside(snakeRow, snakeCol, n, n) )
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (territory[snakeRow, snakeCol] == '*' && food < 10)
                {
                    food++;
                    if (food >= 10)
                    {
                        territory[snakeRow, snakeCol] = 'S';
                        break;
                    }
                }

                if (territory[snakeRow, snakeCol] == 'B')
                {
                    territory[snakeRow, snakeCol] = '.';
                    snakeRow = secondBurRow;
                    snakeCol = secondBurCol;

                }

                territory[snakeRow, snakeCol] = 'S';
                command = Console.ReadLine();
            }

            if (food >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {food}");

            PrintTerritory(n, territory);
        }

        private static void PrintTerritory(int n, char[,] territory)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(territory[row, col]);
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
            if (row < 0 || row >= rows)
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