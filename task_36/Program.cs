/* Задайте одномерный массив, заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0 */

Console.Clear();

int [] array = GetArray (7, 1, 10);
Console.WriteLine(String.Join (" ", array));
int sum = SumElements (array);
Console.WriteLine($"сумма элементов, стоящих на нечетных позициях {sum} ");


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

// логика
int SumElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
         sum += arr[i];
    }
    return sum;   
}

#endregion