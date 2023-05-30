/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


int m = GetNonnegativeUserNumber("Введите число m: ", "Неверный ввод!");
int n = GetNonnegativeUserNumber("Введите число n: ", "Неверный ввод!");
int result = Akkerman(m, n);
Console.WriteLine($" m = {m}, n = {n} -> A(m, n) = {result}");


int GetNonnegativeUserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= 0)
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
