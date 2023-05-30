/* Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N при помощи рекурсии.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

int n = GetUserNumber("Введите число N: ", "Ошибка!");
int start = GetUserNumber("Введите начальное значение: ", "Ошибка!");


if (n > start)
{
    string res = PrintNaturalNums(start, n);
    Console.WriteLine(res);
}
else Console.WriteLine("Значения начальной и конечной точки некорректны");



string PrintNaturalNums (int start, int n)
{
    if (start == n)
    {
        return n.ToString();
    }
    else return start + " " + PrintNaturalNums (start + 1, n);
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
