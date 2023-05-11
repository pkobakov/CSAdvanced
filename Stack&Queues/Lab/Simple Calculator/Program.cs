var input = Console.ReadLine().Split();
var expression = new Stack<string>(input.Reverse());

int result = int.Parse(expression.Pop());

while (expression.Any()) 
{
    string sign = expression.Pop();
    int number = int.Parse(expression.Pop());

    if (sign == "+")
    {
        result += number;
    }

    else if (sign == "-") 
    {
        result -= number;
    }
}

Console.WriteLine(result);