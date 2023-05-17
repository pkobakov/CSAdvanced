var dimensions = Console.ReadLine().Split()
                                   .Select(int.Parse)
                                   .ToArray();

int rows = dimensions[0], columns = dimensions[1];

var matrix = new int[rows, columns];

for (int row = 0; row < rows; row++) 
{
    var figures = Console.ReadLine().Split()
                                    .Select(int.Parse)
                                    .ToArray();

    for (int col = 0; col < columns; col++)
    {
        matrix[row, col] = figures[col]; 
    }
}

int maxSum = int.MinValue;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < columns -2; col++)
    {
        int currentSum =
                 matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                 matrix[row + 1, col] + matrix[row+1, col+1] + matrix[row + 1, col + 2] +
                 matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if (maxSum < currentSum)
        {
            maxSum = currentSum;
            maxRow = row;
            maxCol = col;

        }
    }
}

Console.WriteLine( $"Sum = {maxSum}" );

for (int row = maxRow; row < maxRow + 3; row++)
{
    for (int col = maxCol; col < maxCol + 3; col++) 
    { 
    
        Console.Write( $"{matrix[row, col]} ");
    }

    Console.WriteLine(  );

}