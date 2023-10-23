Add();
Add2(8, 10);
static void Add()
{
    Console.WriteLine("Added");
}

static int Add2(int number1, int number2)
{
    var result = number1 + number2;
    Console.WriteLine("Sonuç: " + result);
    return result;
}
Console.ReadLine();