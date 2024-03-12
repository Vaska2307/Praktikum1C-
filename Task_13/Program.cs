using System;
using static System.Console;
Clear();
Write("Введите трехзначное число: ");
int a1 = int.Parse(ReadLine());
int a2 = new Random().Next(1, 10000);
if(a1 < 100)
{
    WriteLine($"{a1} -> трерьей цифры нет");
}
if (a1 > 100)
{
    WriteLine($"{a1} -> {a1 % 10}");
}
if(a2 < 100)
{
    WriteLine($"{a2} -> трерьей цифры нет");
}
if (a2 > 100)
{
    WriteLine($"{a2} -> {a2 % 10}");
}

