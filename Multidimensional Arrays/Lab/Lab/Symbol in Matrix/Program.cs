int input = int.Parse(Console.ReadLine());
int rows = input, cols = input;

int[,] matrix = new int[rows,cols];

for (int row = 0; row < rows; row++) 
{
    var chars = Console.ReadLine().ToCharArray();;

   for (int col = 0; col < cols; col++) 
   {
        matrix[row, col] = chars[col];  
   }
}

char symbol = char.Parse(Console.ReadLine());

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (matrix[row,col] == symbol)
        {
            Console.WriteLine(  $"({row}, {col})"); return;
        }
    }
}

Console.WriteLine($"{symbol} does not occur in the matrix");