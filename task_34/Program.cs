/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

int [] array = GetArray (15, 100, 999);
Console.WriteLine(String.Join (" ", array));
int count = CountElements (array);
Console.WriteLine($" в данном массиве {count} четных чисел");


#region Methods

// метод для создания массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// логика: определение программой кол-ва четных чисел в массиве
int CountElements(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
         if (el % 2 == 0) count++;
    }
    return count;
}


#endregion









