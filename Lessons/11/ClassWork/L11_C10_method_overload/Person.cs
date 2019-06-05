using System;

namespace L11_C10_method_overload
{
	class Person
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public void WriteProperties(int years)
		{
			Console.WriteLine(
				$"Name: {Name}, age in {years} years: {AgeInSomeYears(years)}.");
		}

		public int AgeInSomeYears(int yearsToAdd)
		{
			return Age + yearsToAdd;
		}

		public void UpdateProperties(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void UpdateProperties(int age)
		{
			Age = age;
		}

		public void UpdateProperties(string name)
		{
			Name = name;
		}
	}
}