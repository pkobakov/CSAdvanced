var dimensions = int.Parse(Console.ReadLine());
var rows = dimensions;
var columns = dimensions;
var matrix = new int[rows, columns];

for (int i = 0; i < rows; i++) 
{
	var nums = Console.ReadLine().Split()
		                         .Select(int.Parse)
								 .ToArray();

	for (int j = 0; j < columns; j++)
	{
		matrix[i, j] = nums[j];
	}
}

int sum = matrix[0, 0];

for (int col = 0; col < columns-1; col++)
{

	
		sum += matrix[col+1, col+1];
	
}

Console.WriteLine(sum);
