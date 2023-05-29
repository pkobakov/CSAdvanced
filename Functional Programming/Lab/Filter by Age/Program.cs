int n = int.Parse(Console.ReadLine());
Func<string, List<string>> ReadPeople = text => text.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
Dictionary<string,int> persons = new Dictionary<string,int>();  
for (int i = 0; i < n; i++)
{
    List<string> person = ReadPeople(Console.ReadLine());  
    string name = person[0];
    int age = int.Parse(person[1]);

    persons.Add(name, age);


    

}

Console.WriteLine(  );