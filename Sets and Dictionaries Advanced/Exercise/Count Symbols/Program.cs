char[] input = Console.ReadLine().ToCharArray();

Dictionary<char, int> myDictionary = new Dictionary<char, int>();
int counter = 1;
for (int i = 0; i < input.Length; i++) 
{
    char currentSymbol = input[i]; 

    if (!myDictionary.ContainsKey(currentSymbol))
    {
        myDictionary.Add(currentSymbol, 1);
    }

    else 
    {
        myDictionary[currentSymbol] ++;
    
    }
}

foreach (char symbol in myDictionary.Keys.OrderBy(x => x)) 
{
     Console.WriteLine($"{symbol}: {myDictionary[symbol]} time/s");

}

