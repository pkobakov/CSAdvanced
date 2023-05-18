using System.Data;
using System.Xml.Linq;

int rows = int.Parse(Console.ReadLine());
int [][] jagged =  new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] array = Console.ReadLine().Split()
                                   .Select(int.Parse)
                                   .ToArray();

    jagged[row] = array;
}

//If a row and the one below it have equal length, multiply each
//element in both of them by 2, otherwise - divide by 2.

for (int row = 0; row < rows - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length) 
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2;
        }
    }

    else
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }
        for (int col = 0; col < jagged[row + 1].Length; col++)
        {
            jagged[(row + 1)][col] /= 2;
        }
        
    }

}

string command = Console.ReadLine();

while (command != "End") 
{
    
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string commandType = tokens[0];
    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);


    if (IsValid( row, col, jagged))
    {
        switch (commandType)
        {
            case "Add":
                jagged[row][col] += value; break;
            case "Subtract":
                jagged[row][col] -= value; break;
                default: break;
        }
    }

    command = Console.ReadLine(); 
}

for (int row = 0; row < rows; row++)
{
    Console.WriteLine(string.Join(" ", jagged[row]));
}

static bool IsValid(int row, int col, int[][] jagged )
{

    return row >= 0 && jagged.Length > row &&
           col >= 0 && jagged[row].Length > col;
}
