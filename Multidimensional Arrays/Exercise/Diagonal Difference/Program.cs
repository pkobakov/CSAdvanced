int size = int.Parse(Console.ReadLine());

int rows = size, cols = size;

var square = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
    for (int col = 0; col < cols; col++) 
    {
        square[row, col] = numbers[col];
    }
}

int primary =  0;
int secondary = 0;

for (int i = 0; i < size; i++) 
{
    primary += square[i, i];
    secondary += square[size-i-1, i];

}

Console.WriteLine(Math.Abs(primary-secondary));