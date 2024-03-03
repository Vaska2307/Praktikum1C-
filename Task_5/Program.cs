using System;

Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int B = -N;
while(B <= N)
{
    Console.Write($"{B} ");
    B++;
}
