using System;// подключаем библиотеки
using static System.Console; // подключаем библиотеки

Clear(); // чистим сонсоль
int[] array = GetMasiiweSum(12, -9, 9); // сщздаем массив array вызвав метод по имени  GetMasiiweSum и задаем его параметры
// (12, -9, 9),,,    12 - колличество элементов массива (размер, size). -9 - минимальная граница (min)..   9 максимальная граница (max). 
WriteLine(String.Join(",", array)); // создаем оператор String.Join и делаем разделитель " , " запятую
// и передаем наш массиа array для вывода в терминал
int positiveSum = 0; // создаем переменную для пложительных чисел
int negativeSum = 0; // создаем переменную для отрицательных чисел
foreach(int item in array)// foreach - это перебор элементов, без возможности их замены, но сравнивать
// элементы элементы массива с нулем можно,, после слова in идет параметрв виде массива array,,  Слева переменная item которая 
// будет переменной массива на каждом шаге 
{
    Write($"{item} ");
    if (item < 0) // сравнение переменной item с нулем
    {
       negativeSum = negativeSum + item; // тело цикла for суммируем переменную negativeSum с помощью переменной item с каждой новой итерацией
       // пока не переберем весь массив array
    }
    else
    {
        positiveSum = positiveSum + item; // в ином случае else суммируем переменную positiveSum с помощью переменной item с каждой новой 
       // итерацией  пока не переберем весь массив array
    }
}
WriteLine();
WriteLine($"Сумма положительных элементов = {positiveSum}, Сумма отрицательных элементов = {negativeSum}"); // выводим результат


int[] GetMasiiweSum(int size, int min, int max) // создаем целочисленный метод int[] метод с именем GetMasiiweSum
// пишем параметры метода (int size, int min, int max), размер int size, минимальное значение int min, максимальное значение int max
{
    int[] result = new int[size]; // создаем переменную  int[] result
    for(int i = 0; i < size; i++) // создаем цикл for, задаем его параметры (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1); // метод с  параметрами минимального диапазона и максимального +1 = Next(min, max + 1)
        // +1 для того, что бы максимальное значение тоде вошло,   new Random() для случайных элементов.
    }
    return result; // возвращаем return, кузультат переменную result
}

