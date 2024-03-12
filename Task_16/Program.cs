using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int a = int.Parse(ReadLine());
Write("Введите второе число: ");
int b = int.Parse(ReadLine());

if (b * b == a)
{
    WriteLine($"a = {a}, b = {b} -> a квадрат b");
}
else
{
    if(Math.Pow(a,2)==b)
    {
        WriteLine($"a = {a}, b = {b} -> b квадрат a");
    }
    else
    {
       WriteLine($"a = {a}, b = {b} -> не является"); 
    }
}
