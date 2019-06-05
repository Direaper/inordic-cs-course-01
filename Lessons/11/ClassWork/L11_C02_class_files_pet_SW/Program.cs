using System;

namespace L11_C02_class_files_pet_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			var pet1 = new Pet();
			pet1.Kind = "Cat";
			pet1.Name = "Tom";
			pet1.Sex = 'M';
			pet1.Age = 8;
			Console.WriteLine(pet1.Description);

			var pet2 = new Pet
			{
				Kind = "Mouse",
				Name = "Minnie",
				Sex = 'F',
				Age = 1
			};
			Console.WriteLine(pet2.Description);
			Console.ReadKey();
		}
	}
}