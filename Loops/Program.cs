
//DÖNGÜLER
//FOR


//for (int i = 100; i >= 0; i=i-2)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Finished!");




//WHILE

//int number = 100;
//while (number >= 0)
//{
//    Console.WriteLine(number);
//    number--;
//}
//Console.WriteLine("Now number is {0}", number);
//Console.ReadLine();

//DO WHILE


//int number = 10;
//do
//{
//    Console.WriteLine(number);
//    number--;

//} while (number >= 0);

//Console.ReadLine();


//FOREACH

//using System.Runtime.CompilerServices;

//string[] students = new string[3] { "Engin", "Atilla", "Umut" };
//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}
//Console.ReadLine();

if (IsPrimeNumber(7))
{
    Console.WriteLine("This is a prime number!");
}
else
{
    Console.WriteLine("This isn't a prime number!");
}

Console.ReadLine();

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number-1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}

