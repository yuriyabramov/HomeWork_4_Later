/* Напишите программу замены элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();

int [] array = GetArray (5, -6, 8);
Console.WriteLine(String.Join (" ", array));

GetAnotherNumbers (array);

Console.WriteLine(String.Join (" ", array));


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


// меняет знак чисел в массиве
void GetAnotherNumbers (int[] arr)
{
   for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}


#endregion