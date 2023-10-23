internal class Program
{
    //Add();
    //Add2(8, 10);

    //int number1 = 100;
    //int number2 = 200;
    //var result = Add3(number1,number2);

    //Console.WriteLine(result);

    static void Main(string[] args)
    {
        //Console.WriteLine(Multiply(2, 4));
        //Console.WriteLine(Multiply(2, 4, 7));

        Console.WriteLine(Add4(1,3,4,8,6,7));
        Console.ReadLine();
    }


//static void Add()
//{
//    Console.WriteLine("Added");
//}

//static int Add2(int number1 = 20, int number2= 30)
//{
//    var result = number1 + number2;
//    Console.WriteLine("Sonuç: " + result);
//    return result;
//}

static int Add3(int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }
}