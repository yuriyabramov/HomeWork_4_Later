/* Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76 */

Console.Clear();

int [] array = GetArray (5, 1, 10);
Console.WriteLine(String.Join (" ", array));
int minNumber = GetMinNumber (array);
int maxNumber = GetMaxNumber (array);
Console.WriteLine($"{maxNumber} - {minNumber} = {maxNumber - minNumber} ");


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

// метод для поиска минимального значения в массиве
int GetMinNumber (int[] arr)
{
    int minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}


// метод для поиска максимального значения в массиве
int GetMaxNumber (int[] arr)
{
    int maxNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}


#endregion


