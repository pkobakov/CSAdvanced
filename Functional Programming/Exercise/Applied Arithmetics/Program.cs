var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));

string command;
while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
        print(numbers);
    else
    {
        Func<int, int> processor = command switch
        {
            "add" => n => n + 1,
            "multiply" => n => n * 2,
            "subtract" => n => n - 1,
            _ => n => n
        };
        numbers = numbers.Select(processor).ToList();

    }
}