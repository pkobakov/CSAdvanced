﻿var input = Console.ReadLine();
var customers = new Queue<string>();

while (input != "End")
{
    
    if (input == "Paid")
	{
        while (customers.Count > 0) 
        {
            Console.WriteLine(  customers.Dequeue());
        }
       
	}

    else
    {
        customers.Enqueue(input);

    }
    

    input = Console.ReadLine();
}

Console.WriteLine($"{customers.Count} people remaining");