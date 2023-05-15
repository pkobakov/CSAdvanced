var commandsCount = int.Parse(Console.ReadLine());
var stack = new Stack<int>();

for (int i = 0; i < commandsCount; i++) 
{
    var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (command.Length == 2) 
    {
        stack.Push(command[1]);
    }

    else 
    {
        var commandType = command[0];

        if (commandType == 2) 
        {
            stack.Pop();
        }
        if (commandType == 3 && stack.Any()) 
        {
            Console.WriteLine(stack.Max());
        }
        if(commandType == 4 && stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
    }
}


   var result = stack.ToArray();
   Console.WriteLine( string.Join( ", ", result)); 



