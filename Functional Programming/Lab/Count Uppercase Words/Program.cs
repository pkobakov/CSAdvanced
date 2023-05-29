using System.Security.Cryptography.X509Certificates;

string input = Console.ReadLine();

Console.WriteLine(PrintUppercaseWords(input));

static string PrintUppercaseWords(string text) 
{
    var test = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    Func<string, bool> check = a => a.Any(x => char.IsUpper(x));
    var result = test.Where(w => check(w)).ToList();
    return $"{string.Join(Environment.NewLine, result)}";
}
