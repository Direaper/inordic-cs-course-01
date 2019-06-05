using System;

namespace L11_C04_methods_pet
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet();
			pet1.Kind = "Cat";
			pet1.Name = "Tom";
			pet1.Sex = 'M';
			pet1.DateOfBirth = DateTimeOffset.Parse("2011-03-14");
			Console.WriteLine(pet1.Description);

			var pet2 = new Pet
			{
				Kind = "Mouse",
				Name = "Minnie",
				Sex = 'F',
				DateOfBirth = DateTimeOffset.Parse("2017-03-14")
			};

			Console.WriteLine(pet2.Description);
			Console.ReadKey();
		}
	}
}