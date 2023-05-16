var dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
var rows = dimensions[0];
var columns = dimensions[1];

var matrix = new int[rows, columns];
int maxSum = int.MinValue;
int a = 0;
int b = 0;
int c = 0;
int d = 0;

for (int row = 0; row < rows; row++)
{
    var numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray(); 

    for (int col = 0; col < columns; col++)
    {
        
        matrix[row, col] = numbers[col];  
    }
}

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < columns - 1 ; col++)
    {
        int currentSum = 0;
        currentSum += matrix[row, col];
        currentSum += matrix[row, col+1];
        currentSum += matrix[row + 1, col];
        currentSum += matrix[row+1, col+1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            a = matrix[row, col];
            b = matrix[row, col+1];
            c = matrix[row+1, col];
            d = matrix[row+1, col+1];
        }
    }
}
Console.WriteLine($"{a} {b}");
Console.WriteLine($"{c} {d}");
Console.WriteLine(maxSum);