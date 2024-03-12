using System;
using static System.Console;
Clear();

Write("Введите число: ");
int a = int.Parse(Console.ReadLine());


if ((a % 7 == 0)&&(a % 23 == 0))
{
    WriteLine($"{a} -> да ");
}
else
{
    WriteLine($"{a} -> нет ");
}
