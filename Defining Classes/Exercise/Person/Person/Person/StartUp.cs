namespace Person
{
    using DefiningClasses;
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

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
	}
}