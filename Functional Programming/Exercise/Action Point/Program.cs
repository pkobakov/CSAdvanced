string input = Console.ReadLine();


Action<string> action = text =>
{
    string [] array = text.Split().ToArray();
    foreach (var item in array)
    {

        Console.WriteLine(item);
    }

};

action(input);




