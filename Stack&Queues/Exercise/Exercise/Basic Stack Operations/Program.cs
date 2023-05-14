var conditions = Console.ReadLine().Split().Select(int.Parse).ToArray();
var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();




bool result = false;
var stack = new Stack<int>();
int min = int.MaxValue;

for (int i = 0; i < conditions[0]; i++)
{
    stack.Push(numbers[i]);
}

for (int i = 0; i < conditions[1]; i++)
{
    stack.Pop();
}

if (stack.Contains(conditions[2])) 
{
    result = true;
    Console.WriteLine(result); return;
}

if (stack.Count == 0)
{
    Console.WriteLine(stack.Count); return; 
}

if (stack.Count > 0 && !stack.Contains(conditions[1])) 
{
    for (int i = 0; i < stack.Count; i++)
    {
        if (stack.Peek() < min)
        {
            min = stack.Pop(); 
        }
    }

    Console.WriteLine(min); return;
}


