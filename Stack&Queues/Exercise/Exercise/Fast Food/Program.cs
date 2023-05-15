var foodQuantity = int.Parse(Console.ReadLine());
var ordersQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

var orders = new Queue<int>(ordersQuantity);

Console.WriteLine(orders.Max());

while(foodQuantity > 0)
{
	if (orders.Count >  0 && orders.Peek() <= foodQuantity)
	{
        foodQuantity -= orders.Dequeue();

	}

	else
	{
		break;
	}
}

if (orders.Count == 0)
{
    Console.WriteLine("Orders complete");
}

else 
{
	var ordersArr = orders.ToArray();
    Console.WriteLine($"Orders left: {string.Join(" ", ordersArr)}");
}
