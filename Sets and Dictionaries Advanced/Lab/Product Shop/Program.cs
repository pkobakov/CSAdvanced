
string command = Console.ReadLine();
Dictionary<string, Dictionary<string, double>> shopList = new Dictionary<string, Dictionary<string, double>>();    
while (command != "Revision") 
{
     string[] cmdArgs = command.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                               .ToArray();

    string superMarket = cmdArgs[0];
    string productName = cmdArgs[1];
    double price = double.Parse(cmdArgs[2]);

    if (!shopList.ContainsKey(superMarket)) 
    {
        shopList.Add(superMarket, new Dictionary<string, double> { { productName, price } });
    }

    else 
    {
        shopList[superMarket].Add( productName, price );
    
    }

    command = Console.ReadLine();

}

foreach (var currentShop in shopList.OrderBy(s => s.Key))
{
    Console.WriteLine( $"{currentShop.Key} -> " );

    foreach (var product in currentShop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }

}
