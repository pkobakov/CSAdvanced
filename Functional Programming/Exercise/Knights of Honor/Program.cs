string input = Console.ReadLine();
Action<string> print =  x => Print(input);
print(input);


void Print(string text) 
{
    string [] result = text.Split().Select(x => "Sir " + x).ToArray();
    Console.WriteLine(string.Join(Environment.NewLine, result));

}


