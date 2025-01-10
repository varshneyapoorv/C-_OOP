namespace Indexers
{

    class Program {
        public static void Main(string[] args)
        {
             var cookie = new HttpCookie();
             cookie["name"] = "apoorv";
             System.Console.WriteLine(cookie["name"]);
        }
    }
}