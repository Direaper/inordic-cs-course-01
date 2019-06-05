using System;

namespace L11_C10_method_overload
{
	class Program
	{
		static void Main()
		{
			// declaring the array for names
			var persons = new Person[2];

			for (var i = 0; i < persons.Length; i++)
			{
				persons[i] = new Person();

				Console.Write($"Enter name {i}: ");
				persons[i].Name = Console.ReadLine();

				Console.Write($"Enter age {i}: ");
				persons[i].Age = int.Parse(Console.ReadLine());
			}

			persons[0].UpdateProperties("Andrei Golyakov");
			persons[0].UpdateProperties("Andrei Golyakov", 36);
			persons[0].UpdateProperties(36);

			// Writing out the results
			for (var i = 0; i < persons.Length; i++)
			{
				persons[i].WriteProperties(4);
				persons[i].WriteProperties(12);
			}

			Console.ReadKey();
		}
	}
}