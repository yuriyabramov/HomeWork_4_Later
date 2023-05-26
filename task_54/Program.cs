/* Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива*/

Console.Clear();

var rows = GetNonnegativeUserNumber("Введите количество строк: ", "Неверный ввод!");
var columns = GetNonnegativeUserNumber("Введите количество столбцов: ", "Неверный ввод!");
var min = GetUserNumber("Введите минимальное значение массива: ", "Неверный ввод!");
var max = GetUserNumber("Введите минаксимальное значение массива: ", "Неверный ввод!");

var arr = GenerateArray(rows, columns, min, max);

Console.WriteLine("Исходный массив: ");

PrintArray(arr);

Console.WriteLine("Сортировка по строкам: ");

SortToLower(arr);

PrintArray(arr);

// Methods

int GetNonnegativeUserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}


int GetUserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}


int[,] GenerateArray (int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
} 
     

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}