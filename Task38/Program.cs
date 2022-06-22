// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(5, 1, 100);
WriteLine($"Заданный массив [{String.Join(",", array)}]");
WriteLine();
int max = array[0];
int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}
int diff = max - min;

WriteLine($"В заданном массиве разница между max и min элементами = {diff}");
WriteLine();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++ )
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

