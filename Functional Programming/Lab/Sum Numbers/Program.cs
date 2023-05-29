string input = Console.ReadLine();

int count = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Count();

int sum = input.Split(", ")
                .Select(int.Parse)
                .Sum();


Console.WriteLine(count);
Console.WriteLine(sum);
                
                  


