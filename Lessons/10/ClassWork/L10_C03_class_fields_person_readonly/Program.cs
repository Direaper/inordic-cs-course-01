using System;

namespace L10_C03_class_fields_person_readonly
{
	class Program
	{
		static void Main()
		{
			var p1 = new Person();
			p1.Name = "Some";
			p1.Age = 12;

			// Now we shouldn't think about the format of output for parameters in the main code
			// We can just call PropertiesString where all the logic is encapsulated
			Console.WriteLine(p1.DisplayName);

			// The line below will not be compiled as the property is read-only!
			// p1.PropertiesString = "Try to override read-only property";
		}
	}

	class Person
	{
		private int m_age;
		public int Age
		{
			get { return m_age; }
			set
			{
				if (value > 0 && value < 140)
				{
					m_age = value;
				}
			}
		}

		public string Name { get; set; }

		public string DisplayName
		{
			get { return $"Name: {Name}, Age: {Age}."; }
		}
	}
}