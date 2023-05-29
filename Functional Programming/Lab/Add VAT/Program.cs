double [] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

Func<double, double> calculateVAT = a => a * 1.2;

foreach (var num in input)
{
    Console.WriteLine($"{calculateVAT(num):f2}");
}





