namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeFour { get; }
        public string Information
        {
            get
            {
                return $"Name: {Name} \n Age{Age} \nage in 4 years: {AgeFour}";
            }
        }
    }
}


