namespace L11_C02_class_files_pet_SW
{
	public class Pet
	{
		public string Kind;
		public string Name;
		public char Sex;
		public byte Age;

		public string Description
		{
			get { return $"{Name} is a {Kind} ({Sex}) of {Age} years old."; }
		}
	}
}