/* Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и 
замените эти элементы на их квадраты. Например, изначально массив 
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */


Console.Clear();

var rows = GetNonnegativeUserNumber("Введите количество строк: ", "Неверный ввод!");
var columns = GetNonnegativeUserNumber("Введите количество столбцов: ", "Неверный ввод!");
var min = GetUserNumber("Введите минимальное значение массива: ", "Неверный ввод!");
var max = GetUserNumber("Введите минаксимальное значение массива: ", "Неверный ввод!");

var arr = GenerateArray(rows, columns, min, max);

PrintArray(arr);

SqureOddIndeces(arr);

Console.WriteLine();

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



void SqureOddIndeces(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2) 
        {
            arr[i,j] = arr[i,j] * arr[i,j];
        }
    }
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