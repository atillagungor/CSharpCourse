

//Value Types
char character = 'A';
bool condition = false;
byte number4 = 0;
short number3 = 5;
int number1 = 10;
long number2 = 200;
double number5 = 10.4;
decimal number6 = 240.4M;
var number7 = 100;


Console.WriteLine("Number1 is {0}",number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Number7 is {0}", number7);
Console.WriteLine("Character is {0}", (int)character);
Console.WriteLine("Day is {0}", (int)Days.Friday);


//Console.WriteLine("Hello World!");
Console.ReadLine();


enum Days
{
    Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}