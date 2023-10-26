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

        Customer customer = new Customer();
        customer.FirstName = "Atilla";
        customer.LastName = "Güngör";
        customer.City = "İstanbul";

        Customer customer1 = new Customer
        {
            Id = 1,
            City = "İstanbul"
        };

        Console.WriteLine(customer.FirstName);


        Console.ReadLine();
    }
}