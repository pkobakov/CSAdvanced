var conditions = Console.ReadLine().Split().Select(int.Parse).ToArray();
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

var n = conditions[0];
var s = conditions[1];
var x = conditions[2];



string result  =null ;
var stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    stack.Push(numbers[i]);
}

for (int i = 0; i < s; i++)
{
    if (stack.Any())
    {
        stack.Pop();

    }
    else 
    { 
        break;
    }
}

if (stack.Contains(x))
{
    result = "true";
}
else 
{

    if (stack.Count == 0)
    {
        result = "0"; 
    }

    else
    {
         
        result = $"{stack.Min()}";
         
    }

}

Console.WriteLine(result);
