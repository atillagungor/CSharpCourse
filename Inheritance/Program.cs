using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Student student = new Student();
        student.Departmant = "Software";

        Person[] person = new Person[3]
        {
            new Customer
            {FirstName =  "Atilla" },
            new Student
            {FirstName = "Arda"},
            new Person
            {FirstName = "Engin"}
        }; 
        foreach (var item in person)
        {
            Console.WriteLine(item.FirstName);
        }

        Console.ReadLine();
    }
}


class Person
{
    public int Id {  get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string City { get; set; }
}

class Student : Person
{
    public string Departmant { get; set; }
}