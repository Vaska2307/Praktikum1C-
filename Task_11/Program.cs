using System;
using static System.Console;
Clear();
Write("Введите превое число: ");
int number1 = int.Parse(Console.ReadLine());
Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 % number2 == 0)
{
    WriteLine($"{number1} кратно ");
}
else
{
    WriteLine($"{number1} не кратно, остаток {number1 % number2}");
}

