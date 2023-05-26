/* Задайте двумерный массив. напиште пргограмму, которая заменяет строки на столбцы.
В случае, если это невозможно, она выводит сообщение пользователю.*/


Console.Clear();

var rows = GetNonnegativeUserNumber("Введите количество строк: ", "Неверный ввод!");
var columns = GetNonnegativeUserNumber("Введите количество столбцов: ", "Неверный ввод!");
var min = GetUserNumber("Введите минимальное значение массива: ", "Неверный ввод!");
var max = GetUserNumber("Введите минаксимальное значение массива: ", "Неверный ввод!");

var arr = GenerateArray(rows, columns, min, max);

PrintArray(arr);

int [,] result = Transpose(arr);

Console.WriteLine();

PrintArray(result);


// Methods

int[,] Transpose(int[,] arr)
{
    int[,] res = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
            res[j, i] = arr[i, j];
         }
    }
    return res;
}


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