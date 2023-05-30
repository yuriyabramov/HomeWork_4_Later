/* Задайте значения M и N. Напишите программу, которая при помощи рекурсии 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120 
M = 4; N = 8. -> 30 */

//Console.Clear();
var m = GetUserNumber("Введите число M: ", "Ошибка!");
var n = GetUserNumber("Введите число N: ", "Ошибка!");
int result = GetSum(m, n);
Console.WriteLine($"M = {m}, N = {n} -> {result}");



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



int GetSum(int m, int n)
{
    if (m == n) return n;
    else return m + GetSum(m + 1, n);              
}
