﻿/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
Найдите сумму отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20 */

Console.Clear();

int [] array = GetArray (12, -9, 9);
Console.WriteLine(String.Join (" ", array));

int positiveSum = GetPositiveSum (array);
int negativeSum = GetNegativeSum (array);

Console.WriteLine ($"Positive sum = {positiveSum}, negativeSum = {negativeSum} ");

#region 
// генерирует и выводит массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// возвращает сумму положительных чисел массива arr
int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
    }
    return positiveSum;
}


// возвращает сумму отрицательных чисел массива arr
int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        negativeSum += el < 0 ? el : 0;
    }
    return negativeSum;
}
#endregion