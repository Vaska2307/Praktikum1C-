using System;
using static System.Console;

Clear();
Write("Введите число: ");
WriteLine($"Колличество цифр в числе = {GetCountNumbers(int.Parse(ReadLine()))}");



int GetCountNumbers(int number)
{
    int count = 0;
    while(number > 0)
    {
        count++;
        number /=10;
    }
    return count;
}