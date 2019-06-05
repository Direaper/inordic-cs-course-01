using System;

namespace L11_C13_constructors_pet_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet(
				"Cat",
				"Tom",
				'M',
				DateTimeOffset.Parse("2011-03-14"));
			pet1.WriteDescription();

			var pet2 = new Pet(
				"Mouse",
				"Minnie",
				'F',
				DateTimeOffset.Parse("2017-03-14"));
			pet2.WriteDescription(true);

			Console.ReadKey();
		}
	}
}