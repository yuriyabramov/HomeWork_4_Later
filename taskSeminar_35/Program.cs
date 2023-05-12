/* Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения
которых лежат в отрезке [10,99] */

Console.Clear();

int [] array = GetArray (123, 50, 200);
Console.WriteLine(String.Join (" ", array));
int count = FindElements (array);
Console.WriteLine($" в данном массиве {count} элементов в пределе от 10 до 99");



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



/* выводит количество элементов массива, значения
которых лежат в отрезке [10,99] */

int FindElements (int [] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el >= 10 && el <= 99) 
        count++;
    }
    return count;
}


#endregion