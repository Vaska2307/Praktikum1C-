using System;

Console.Clear();
Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int B = N % 10;


Console.WriteLine(B);

Console.Write($"{B} ");

