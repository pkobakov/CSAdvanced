int row = 3;
int col = 4;

var matrix = new int [row, col];

for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 1; j <= matrix.GetLength(1); j++)
	{
        Console.Write(j);
    }
    Console.WriteLine();
}

