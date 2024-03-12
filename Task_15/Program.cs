using System;
using static System.Console;
Clear();
Write("Введите число: ");
int a = int.Parse(ReadLine());

if(a < 6)
{
    WriteLine($"{a} -> нет");
}
if (a > 7)
{
    WriteLine($"{a} -> нет");
}
else
{
    WriteLine($"{a} -> да");
}
