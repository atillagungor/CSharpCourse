using Classes;
using System.Data.SqlTypes;

internal class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Console.ReadLine();
    }
}