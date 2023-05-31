namespace DefiningClasses
{
	using System;
	public class StartUp
	{
		public static void Main(string[] args)
		{
			

			Person person1 = new Person();
			Person person2 = new Person(18);
			Person person3 = new Person("Jose", 43);

            Console.WriteLine(person1.Name);
			Console.WriteLine(person2.Age);
			Console.WriteLine(person3.Name);
        }
	}
}