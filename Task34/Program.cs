// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(4, 100, 999);
WriteLine($"Заданный массив [{String.Join(",", array)}]");
WriteLine();
WriteLine($"В заданном массиве количество четных чисел = {GetEvenAmount(array)}");
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

int GetEvenAmount(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)  amount ++; 
    }
    return amount;
}

