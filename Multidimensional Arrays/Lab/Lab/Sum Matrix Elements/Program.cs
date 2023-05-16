var dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
	                               .Select(int.Parse)
								   .ToArray();
int row = dimensions[0];
int col = dimensions[1];
var matrix = new int[row, col]; 

for (int i = 0; i < matrix.GetLength(0); i++) 
{
	var numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
		                            .Select(int.Parse)
									.ToArray();

	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		matrix[i, j] = numbers[j];
	}
}

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++) 
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		sum += matrix[i, j];
	} 
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);