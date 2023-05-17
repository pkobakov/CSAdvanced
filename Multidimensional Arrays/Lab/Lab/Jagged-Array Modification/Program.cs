int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    matrix[row] = Console.ReadLine().Split()
                                .Select(int.Parse)
                                .ToArray();
}

string command = Console.ReadLine().ToLower();

while (command != "end") 
{
   string [] splitted = command.Split(' ');
    string commandType = splitted[0].ToLower();
    int row = int.Parse(splitted[1]);
    int col = int.Parse(splitted[2]);
    int value = int.Parse(splitted[3]);

    bool isValid = true;

    if ( row < 0 || matrix.Length <= row) 
    {
        isValid = false;

    }

    else
    {
        if (matrix[row].Length <= col || col < 0 )
        {
            isValid = false;
        }
    }

    if (isValid)
    {
        switch (commandType) 
        {
           case "add":
                matrix[row][col] += value;
                break;
            case "subtract": 
                matrix[row][col] -= value;
                break;
            default: break;
        }
    }

    else
    {
        Console.WriteLine("Invalid coordinates");
    }

    command = Console.ReadLine().ToLower();
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} " );
    }
    Console.WriteLine();
}