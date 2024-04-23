using System;
using static System.Console;

Clear();

int[] array = GetArray(123, 0, 1000);// создаем массив
int countElements = GetCountElements(array, 10, 99);// теперь поситаем нашу переменную
WriteLine($"Колличество эллемементов в отрезке [10; 99] = {countElements}");

// метод который вернет к-во элементов в заданном диапазоне
int GetCountElements(int[] inArray, int leftRange, int rightRange)
{
    int count = 0; // переменная которая будет считать наши элементы
    foreach(int item in inArray)
    {
        if(item >= leftRange&&item <= rightRange)
        {
            count++;
        }
    }
    return count;
}


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}