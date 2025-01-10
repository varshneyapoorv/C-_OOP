namespace AccesModifiers {
    public class Person{
        private DateTime _birthDate;
    

    public void SetBirthDate (DateTime birthDate){
        _birthDate = birthDate;
    }

    public DateTime GetBirthDate(){
        return _birthDate;
    }

    class Program {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            System.Console.WriteLine(person.GetBirthDate()); 
        }
    }
}

}