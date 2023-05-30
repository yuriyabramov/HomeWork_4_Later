/* Напишите программу, коотрая будет принимать на вход число 
и будет возвращать сумму его цифр при помощи рекурсии.
453 -> 12
45 -> 9 */

var n = GetUserNumber("Введите число: ", "Ошибка!");
var res = GetSumDigits(n);
Console.WriteLine(res);


int GetSumDigits(int number)
{
    if (number == 0) return 0;
    return number % 10 + GetSumDigits(number / 10);
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