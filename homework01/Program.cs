// Task 1.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write($"The {number} is divisible by 7 and 23 without remainder");
}
else
{
    Console.Write($"The {number} is not divisible by 7 and 23 without remainder");
}
*/

//Task 2.
//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
/*
Console.Write("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y ==0)
{
    Console.Write("Please try again, X or Y can not be 0");
}
else if ( x > 0 && y > 0)
{
    Console.Write($"{x},  {y} => 1");
}
else if ( x < 0 && y > 0)
{
    Console.Write($"{x},  {y} => 2");
}
else if ( x < 0 && y < 0)
{
    Console.Write($"{x},  {y} => 3");
}
else if ( x > 0 && y < 0)
{
    Console.Write($"{x},  {y} => 4");
}
*/

//Task 3.
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10;
int b = number % 10;

if (number >= 10 && number <= 99)
{
    if (a > b)
    {
        Console.Write($"{number} => {a}");
    }
    else if (b > a)
    {
        Console.Write($"{number} => {b}");
    }
    else
    {
        Console.Write($"{number} => {a} and {b} equal");
    }
}
else
{
    Console.Write("The number must be between 10 and 99 inclusive");
}
*/

//Task 4.
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("The number must be a natural number.");
}
else
{
    Console.Write($"{number} => ");

    int copyNumber = number;
    int divisor = 1;

    while (copyNumber / 10 != 0)
    {
        copyNumber /= 10;
        divisor *= 10;
    }

    while (divisor >= 1)
    {
        int digit = number / divisor;
        Console.Write(digit);

        number %= divisor;
        divisor /= 10;

        if (divisor >= 1)
        {
            Console.Write(", ");
        }
    }
}
