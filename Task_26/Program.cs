using System;
using static System.Console;

Clear();
Write("Введите число N: ");
WriteLine($"Произведение от 1 до N = {GetCompositionNumber(int.Parse(ReadLine()))}");


int GetCompositionNumber(int number)
{
    int composit = 1;
    for(int i = 2; i <= number; i++)
    {
        composit *= i;
    }
    return composit;
}