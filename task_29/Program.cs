/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] */

 /*Console.Clear();

 int[] randomArray = new int [8];
 FillArray(randomArray);
 PrintArray(randomArray);


 static void FillArray(int[] collection)
 {
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
 }


 static void PrintArray (int[] collection)
 {
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write ($"{collection [index]}");
        index++;
    }
 }  */

 int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
