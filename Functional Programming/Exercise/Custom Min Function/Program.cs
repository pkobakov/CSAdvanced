string input = Console.ReadLine();

Func<string, int> min = x => MinNumber(input);
int result = min(input);
Console.WriteLine(result);

int MinNumber(string text) 
{
    int[] arr = text.Split().Select(int.Parse).OrderBy(x => x).ToArray();
    return arr[0];
}