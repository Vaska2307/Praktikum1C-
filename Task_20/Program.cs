using System;
using static System.Console;

Clear();

Write("Введите координату X1: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату Y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату X2: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату Y1: ");
int y2 = int.Parse(ReadLine());



double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
WriteLine($"Длинна отрезка равна = {distance:f2}");








