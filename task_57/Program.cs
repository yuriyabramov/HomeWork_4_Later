/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент входных данных.*/


Console.Clear();

int[,] array = new [,]
{
    {5, 3, 2, 4, 5},
    {2, 0, 6, 1, 7},
    {8, 2, 2, 4, 6}
};

PrintArray(array);

int[,] result = GetFrequency(array);

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


int[,] GetFrequency(int[,] arr)
{
    int min = FindMin(arr);
    int max = FindMax(arr);
    int[,] res = new int[max - min + 1, 2];
    for(int i = 0; i < res.GetLength(0); i++)
    {
        res[i, 0] = i;
        res[i, 1] = FindNumberCount(arr, res[i, 0]);
    }
    return res;
}

int FindMin(int[,] arr)
{
    int min = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
            }
        }
    }
    return min;
}


int FindMax(int[,] arr)
{
    int max = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max)
            {
                max = arr[i, j];
            }
        }
    }
    return max;
}


int FindNumberCount(int[,]arr, int number)
{
    int count = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                count++;
            }
        }
    }
    return count;
}