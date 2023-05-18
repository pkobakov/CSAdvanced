int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = dimensions[0];
int cols = dimensions[1];

char[] word = Console.ReadLine().ToCharArray();

char[,] snakePath = new char [rows, cols];
int currentIndex = 0;

for (int row = 0; row < rows; row++)
{

	if (row % 2 == 0)
	{
		for (int col = 0; col < cols; col++)
		{
			if (currentIndex == word.Length )
			{

				currentIndex = 0;
			}

			snakePath[row, col] = word[currentIndex];
			currentIndex++;
	    }
	}
	
	else
	{
		for(int col = cols -1 ; col >= 0; col--) 
		{
            if (currentIndex == word.Length)
            {

                currentIndex = 0;
            }

            snakePath[row, col] = word[currentIndex];
            currentIndex++;
        }
	}
}

PrintMatrix(snakePath);

static void PrintMatrix(char[,] snakePath)
{
    for (int i = 0; i < snakePath.GetLength(0); i++)
    {
        for (int j = 0; j < snakePath.GetLength(1); j++)
        {
            Console.Write($"{snakePath[i, j]}");
        }

        Console.WriteLine();
    }
}

