/* Задайте двумерный массив. Напишите программу, которая 
поменяет местами первую и последнюю строку массива.*/

Console.Clear();

int[,] array = new [,]
{
    {5, 3, 8, 10, 1},
    {2, 0, 5, 4, 3},
    {8, 3, 1, 5, 8}
};

PrintArray(array);

int[,] result = ChangeRows(array); // создаем новый массив // или (array, 1, 2) для закоментированного метода

Console.WriteLine();

PrintArray(result);

///////////////////////////////////////////////

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{i}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// метод чтобы поменять местами первую и последнюю строку массива
int[,] ChangeRows(int[,] arr)
{
    int[,] res = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                res[i, j] = arr[arr.GetLength(0) - 1, j];
                res[res.GetLength(0) - 1, j] = arr[i, j];
            }
            else
            {
                res[i, j] = arr[i, j];
            }
        }
    }
    return res;
} 


/* метод, чтобы поменять все строки в массиве
int[,] ChangeRows(int[,] arr, int row1, int row2)
{
    int[,] res = CopyArray(arr);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        res[row1, j] = arr[row2, j];
        res[row2, j] = arr[row1, j];
                   
    }
    return res;
}

int[,] CopyArray(int[,]arr)
{
    int[,] res = new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = arr[i, j];
        }
    }
    return res;
}*/