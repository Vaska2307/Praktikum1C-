using System;
using static System.Console;

Clear();

int[] array = GetReplaceNum(8, -10, 10);
WriteLine(String.Join(" ", array));
InversArray(array);
WriteLine(String.Join(" ", array));

int[] GetReplaceNum(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max +1);
    }
    return result;
}
void InversArray(int[] inArray)
{
    for(int i =1; i < inArray.Length; i++)
    {
        inArray[i]*=-1;
    }
}