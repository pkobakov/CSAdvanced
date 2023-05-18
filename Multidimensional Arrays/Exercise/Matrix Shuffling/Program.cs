using System.Data;
using System.Data.Common;
using System.Globalization;

int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = array[col];
	}
}

string command = Console.ReadLine();

while (command != "END")
{
    string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    //swap row1 col1 row2 col2
   
    if (IsValid(rows, cols, commandArgs))
    {
        int row1 = int.Parse(commandArgs[1]);
        int col1 = int.Parse(commandArgs[2]);
        int row2 = int.Parse(commandArgs[3]);
        int col2 = int.Parse(commandArgs[4]);

        string temp = matrix[row1, col1];
        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = temp;

        PrintMatrix(matrix);
    }

    else
    {
        Console.WriteLine("Invalid input!");
    }


    command = Console.ReadLine();
}

static bool IsValid(int rows, int cols, string[] args)
{
    bool isValid = 
        args[0] == "swap" 
        && args.Length == 5
        && int.Parse(args[1]) >= 0 && int.Parse(args[1]) < rows 
        && int.Parse(args[2]) >= 0 && int.Parse(args[2]) < cols
        && int.Parse(args[3]) >= 0 && int.Parse(args[3]) < rows
        && int.Parse(args[4]) >= 0 && int.Parse(args[4]) < rows;


    return isValid;
}

static void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

