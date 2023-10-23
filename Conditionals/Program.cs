
//Karar yapıları

var number = 10;

//IF-ELSE


//if (number == 10)
//{
//    Console.WriteLine("Number is {0}", number);
//}
//else if (number == 20)
//{
//    Console.WriteLine("Number is {0}", number);
//}

//else
//{
//    Console.WriteLine("Number isn't {0}", number);
//}


//SWITCH-CASE


//switch (number)
//{
//    case 10:
//        Console.WriteLine("Number is {0}", number);
//        break;
//    case 20:
//        Console.WriteLine("Number is {0}", number);
//        break;
//    default:
//        Console.WriteLine("Number is not 10 or 20");
//        break;
//}



//ÇOKLU KOŞUL


//if (number>= 0 && number <= 100)
//{
//    Console.WriteLine("Number is between 0-100");
//}
//else if (number > 100 && number <= 200)
//{
//    Console.WriteLine("Number is between 101-200");
//}
//else if (number > 200 || number < 0)
//{
//    Console.WriteLine("Number is less than 0 or greater than 200");
//}


//İÇ İÇE KOŞUL

if (number < 100)
{
    if (number >= 90 && number < 100)
    {
        Console.WriteLine("Number is between 90-99");
    }
}


Console.ReadLine();