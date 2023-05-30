/* напишите программу, которая на вход принимает два числа A и B
и возводит число A в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 */

var A = GetUserNumber("Введите первое число: ", "Ошибка!");
var B = GetUserNumber("Введите второе число: ", "Ошибка!");
int result = GetPow(A, B);
Console.WriteLine($"{A} в степени {B} -> {result}");



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


int GetPow(int numb1, int numb2)
{
    if (numb2 == 0) return 1;
    if (numb2 == 1) return numb1;
    return numb1 * GetPow(numb1, numb2 - 1);
}