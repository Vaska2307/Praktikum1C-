using System;
using static System.Console;
Clear();

Write("Введите трехзначное число: ");
int number = int.Parse(ReadLine());

WriteLine($"{number}->{(number % 100) / 10} ");


