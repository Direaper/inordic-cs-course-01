namespace L11_C03_methods
{
	class Person
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public int AgeInFourYears
		{
			get { return Age + 4; }
		}

		public string Description
		{
			get { return $"Name: {Name}, age in 4 years: {AgeInFourYearsMethod()}."; }
		}

		public int AgeInFourYearsMethod()
		{
			return AgeInFourYears;
		}
	}
}