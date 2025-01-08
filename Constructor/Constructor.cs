using System.Security.Cryptography.X509Certificates;

namespace CSharpIntermediate
{

    class Program{
        public static void Main(string[] args)
    {
        var customer = new Customer(1, "Apoorv");

        var order = new Order();
        // customer.Orders = new List<Order>();
        customer.Orders.Add(order);

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);



        
    }
    }
}
