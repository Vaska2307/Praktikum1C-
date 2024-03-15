using System;
using static System.Console;
Clear();

Write("Введите координату Х: ");
int X = int.Parse(ReadLine());
Write("Введите координату У: ");
int Y = int.Parse(ReadLine());

if (X > 0&&Y > 0)
{
    WriteLine($"Четверть номер 1 ");
}
if (X < 0&&Y > 0)
{
    WriteLine($"Четверть номер 2 ");
}
if (X < 0&&Y < 0)
{
    WriteLine($"Четверть номер 3 ");
}
if (X > 0&&Y < 0)
{
    WriteLine($"Четверть номер 4 ");
}