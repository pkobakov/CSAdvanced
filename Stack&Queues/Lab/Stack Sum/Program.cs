using System.ComponentModel.Design.Serialization;

string input = Console.ReadLine();
var arrayOfNumbers = input.Split().Select(int.Parse).ToArray();

var  stack = new Stack<int>(arrayOfNumbers);

var command = Console.ReadLine().ToLower();


while (command != "end")
{ 
    string[] commandInfo = command.Split();

    if (commandInfo[0] == "add") 
    {
        int[] numbers = commandInfo.Skip(1).Select(int.Parse).ToArray();
        
        foreach (var number in numbers)
        {
            stack.Push(number);   
        } 
    }

    else if (commandInfo[0] == "remove")
    {
        int n = int.Parse(commandInfo[1]);

        if (n <= stack.Count)
        {
            while (n > 0)
            {
                stack.Pop();

                n--;
            }
        }

    }

    command = Console.ReadLine().ToLower();
}

Console.WriteLine($"Sum: {stack.Sum()}");


