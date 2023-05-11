var input = Console.ReadLine();

var stack = new Stack<char>(input);

while (stack.Any()) 
{
    var result = stack.Pop();   
    Console.Write(result);
}
