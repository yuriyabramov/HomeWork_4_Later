// методы для создания и заполнения двумерных массивов


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


// метод для печати массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

// метод для заполнения
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        matr[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

