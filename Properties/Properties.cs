namespace Properties
{

    class Program {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            System.Console.WriteLine(person.Age);
        }
    }
}