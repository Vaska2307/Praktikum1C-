using System;
using static System.Console;

Clear();
WriteLine("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());

int[] outArray = GetResultArray(array);
WriteLine(string.Join(" ", outArray));

int[] GetArrayFromString(string stringArray)//  в качестве параметра передаем строку strung и называем 
//переменную stringArray
{
    string[] numS = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);// разобьем строку на подстроки
    int[] result = new int[numS.Length];

    for(int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}
// Пишем метод который будет формировать нам новый массив
int[] GetResultArray(int[] inArray)
{
    int size = inArray.Length / 2; // размер массива будет в 2 раза меньше, именно по этому
    if(inArray.Length % 2 == 1) size++; //в случае если длинна массива не четная, например 5 элементов
    // тогда size++ (размер + 1 элемент) Это метод определиния на четность inArray.Length % 2 == 1
    //в случае нечетности, это позволит нам создать центральный элемент вконце массива.

    int[] result = new int[size];// создаем наш result с полученными размерами size.

    for(int i = 0; i < inArray.Length / 2; i++) // теперь с помощью for пройдемся по нашему входному массиву,
    //но колличество обходов сократим в 2 раза
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];// первый элемент  массива inArray[i] мы 
        // умножеем * на конечный элемент inArray[inArray.Length // но в виде того что элементы массива 
        // нумеруются с 0 то inArray.Length - 1 (порядковы номер элемента) и отнимаем элемент массива из конца
        // массива -i
    }

    if(inArray.Length % 2 == 1) result[size - 1] = inArray[inArray.Length / 2];// в конце не забываем про 
    // наш центральный элемент массива в случае когда колличество элементов не четное
    
    return result;
}