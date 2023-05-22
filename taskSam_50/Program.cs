/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m- 1; n- 7 -> такого числа в массиве нет */


Console.Clear();
int[,] matrix = new int[4, 6];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: "); 
FindNumber(matrix);



// метод для заполнения массива
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


// метод для ввода координат
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



void FindNumber(int[,] matr)
{
    if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
    else Console.WriteLine($"{rows}, {colums} -> такого числа в массиве нет");
}