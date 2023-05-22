/* Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
диагонали (с индексами (0,0); (1;1) и т.д. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */


Console.Clear();

var rows = GetNonnegativeUserNumber("Введите количество строк: ", "Неверный ввод!");
var columns = GetNonnegativeUserNumber("Введите количество столбцов: ", "Неверный ввод!");
var min = GetUserNumber("Введите минимальное значение массива: ", "Неверный ввод!");
var max = GetUserNumber("Введите минаксимальное значение массива: ", "Неверный ввод!");

var arr = GenerateArray(rows, columns, min, max);

PrintArray(arr);

int result = GetDiagonalSum(arr); 

Console.WriteLine();

PrintDiagonal(arr);

Console.WriteLine(result);




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



int GetDiagonalSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, i];
    }
    return sum;
}


void PrintDiagonal(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i, i]);
        if (i < arr.GetLength(0) - 1)
        {
            Console.Write("+");
        }
    }
    Console.Write("=");
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
