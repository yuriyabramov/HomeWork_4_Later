/* Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */ 

Console.Clear();
int n = GetUserNumber("Введите число N: ", "Ошибка!");
int finish = GetUserNumber("Введите конечное значение: ", "Ошибка!");

if (finish < n)
{
    string res = PrintNaturalNums(finish, n);
    Console.WriteLine(res);
}
else Console.WriteLine("Значения начальной и конечной точки некорректны");



string PrintNaturalNums (int finish, int n)
{
    if (finish == n)
    {
        return n.ToString();
    }
    else return n + " " + PrintNaturalNums (finish, n - 1);
}



int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}