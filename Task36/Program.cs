﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(4, -100, 99);
WriteLine($"Заданный массив [{String.Join(",", array)}]");
WriteLine();
WriteLine($"В заданном массиве сумма нечетных элементов = {GetUnevenPositionSum(array)}");
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

int GetUnevenPositionSum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        sum = sum + array[i]; 
        i = i + 1;
    }
    return sum;
}

