/* Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования. */

int length = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите значение max: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите значение min: ", "Ошибка ввода!");
int[] array = GetArray(length, min, max);
Console.WriteLine(String.Join(", ", array));
int[] result = CopyArray(array);
Console.WriteLine(String.Join(", ", array));

// метод для ввода длин сторон
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
        
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
        return result;
}




