var dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

var rows = dimensions[0];
var columns = dimensions[1];

var matrix = new int[rows, columns];

for (var i = 0; i < rows; i++)
{
    var numbers = Console.ReadLine().Split()
                                   .Select(int.Parse)
                                   .ToArray();
    
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = numbers[j];
    }
}


for (var i = 0;i < columns; i++) 
{
    int sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum += matrix[j, i];
    }

    Console.WriteLine(sum);
}

