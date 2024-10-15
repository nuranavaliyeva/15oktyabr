using ConsoleApp11.Models;
using System.Net.Http.Headers;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product = new product("Apple", "Iphone13", 10m, 20m, 11);
            product.Sale(-1);
            Console.WriteLine(product.GetInfo());
            


        }
    }
}
