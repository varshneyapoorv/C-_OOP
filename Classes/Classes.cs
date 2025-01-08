using System;
using Classes;

namespace Classes
{
    public class Person {
        public string Name;

        public  void Introduce (string to){
            Console.WriteLine($"Hi {0}, I am {1}", to, Name);
            
        }
    }
}

class Program{
    public static void Main(string[] args)
    {
        var person =  new Person();
        person.Name = "John";
        person.Introduce("Apoorv");
    }
}