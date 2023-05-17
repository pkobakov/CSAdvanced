using System.Data.Common;

var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

int rows = dimensions[0];
int columns = dimensions[1];    

var matrix = new string[rows, columns];
int counter = 0;

for (int row = 0; row < rows; row++) 
{
    var symbols = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

    for (int col = 0; col < columns ; col++)
    {
        matrix[row, col] = symbols[col];
    }
}

for (int i = 0; i < rows -1 ; i++)
{
    for (int j = 0; j < columns - 1 ; j++)
    {
        string a = matrix[i, j]; 
        string b = matrix[i, j + 1];    
        string c = matrix[i + 1,j] ;
        string d = matrix[i + 1, j + 1];

        if (a == b && 
            b == c &&
            c == d)
        {
            counter++;  
        }

        //else { continue; }

    }
}

Console.WriteLine(counter);
