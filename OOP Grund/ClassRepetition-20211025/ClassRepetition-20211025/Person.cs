namespace ClassRepetition_20211025
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public static Person New()
        {
            return new Person();
        }

        public string GetWholeName()
        {
            return $"{Name} {LastName}";
        }
    }
}
