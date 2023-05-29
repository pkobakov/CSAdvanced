using System.Security.Cryptography.X509Certificates;

string input = Console.ReadLine();

Console.WriteLine(PrintUppercaseWords(input));

static string PrintUppercaseWords(string text) 
{
    var test = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    var result = new List<string>();
    Func<string, bool> check = a => a.Any(x => char.IsUpper(x));
    foreach (var word in test) 
    {
        if (check(word))
        {
            result.Add(word);
        }
    }
    return $"{string.Join(Environment.NewLine, result)}";
}
