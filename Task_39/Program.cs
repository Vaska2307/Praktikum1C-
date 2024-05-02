using System;
using static System.Console;

Clear();
Write("Введите размер массива: ");
int n = int.Parse(ReadLine());
int[] array1 = GetArray(n, 1, 10);
WriteLine(String.Join(" ", array1));

int[] array2 = ReverseArray1(array1);
WriteLine(String.Join(" ", array2));
ReverseArray2(array1);
WriteLine(String.Join(" ", array1));

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[inArray.Length-1-i];
    }
    return result;
}
void ReverseArray2(int[] inArray)
{
    for(int i = 0; i < inArray.Length/2; i++ )
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length -1 - i];
        inArray[inArray.Length -1 - i] = k;
    }

}
