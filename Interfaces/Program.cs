using Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();
        //Demo2();

        ICustomerDal[] customerDals = new ICustomerDal[3]
        {
             new SqlServerCustomerDal(),
             new OracleCustomerDal(),
             new MySqlCustomerDal(),
         };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
        Console.ReadLine();
    }

    private static void Demo2()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new OracleCustomerDal());
    }

    private static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Atilla",
            LastName = "Güngör",
            Address = "İstanbul"
        };
        Student student = new Student
        {
            Id = 1,
            FirstName = "Attila",
            LastName = "Güngör",
            Departmant = ".Net"
        };
        Worker worker = new Worker
        {
            Id = 1,
            FirstName = "Attilla",
            LastName = "Güngör",
            Departmant = "c#"
        };
        manager.Add(customer);
        manager.Add(student);
        manager.Add(worker);
    }
}




interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address {  get; set; }

}

class Student:IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant {  get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}