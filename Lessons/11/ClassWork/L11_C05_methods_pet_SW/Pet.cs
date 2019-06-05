using System;

namespace L11_C05_methods_pet_SW
{
	public class Pet
	{
		public string Kind;
		public string Name;
		public char Sex;
		public DateTimeOffset DateOfBirth;

		public int Age()
		{
			var age = DateTimeOffset.UtcNow.Subtract(DateOfBirth);
			return Convert.ToInt32(Math.Floor(age.TotalDays / 365.242));
		}

		public string Description
		{
			get { return $"{Name} is a {Kind} ({Sex}) of {Age()} years old."; }
		}

		public void WriteDescription()
		{
			Console.WriteLine(Description);
		}
	}
}