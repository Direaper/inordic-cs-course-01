using System;

namespace L11_C05_methods_pet_SW
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
			pet1.WriteDescription();

			var pet2 = new Pet
			{
				Kind = "Mouse",
				Name = "Minnie",
				Sex = 'F',
				DateOfBirth = DateTimeOffset.Parse("2017-03-14")
			};
			pet2.WriteDescription();
			Console.ReadKey();
		}
	}
}