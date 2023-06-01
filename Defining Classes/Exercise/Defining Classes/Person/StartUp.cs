namespace DefiningClasses
{ 
    using System;
    public class StartUp
    {
		public static void Main(string[] args)
		{
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personArgs = Console.ReadLine().Split().ToArray();

                Person person = new Person(personArgs[0], int.Parse(personArgs[1]));
                family.AddMember(person);
            }

            foreach (var person in family.People.Where(p => p.Age > 30).OrderBy(p => p.Name)) 
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
	}
}