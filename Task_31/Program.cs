using System;
using static System.Console;

Clear();
int[] array = GetMasiiweSum(12, -9, 9);
WriteLine(String.Join(",", array));
int positiveSum = 0;
int negativeSum = 0;
foreach(int item in array)// foreach - это перебор элементов
{
    Write($"{item} ");
    if (item < 0)
    {
       negativeSum = negativeSum + item;
    }
    else
    {
        positiveSum = positiveSum + item;
    }
}
WriteLine();
WriteLine($"Сумма положительных элементов = {positiveSum}, Сумма отрицательных элементов = {negativeSum}");


int[] GetMasiiweSum(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

