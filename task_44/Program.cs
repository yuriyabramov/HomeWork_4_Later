/* Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1. 
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int number = GetNumberFromUser("Введите количество чисел Фибоначчи: ", "Ошибка ввода!");
int[] result = GetFibo(number);
Console.WriteLine(String.Join(", ", result));


// метод для ввода длин сторон
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        Console.WriteLine(errorMessage);
    }
}


int[] GetFibo(int n)
{
    int[] result = new int[n];
    result[0] = 0;
    if (n > 1)
    {
        result[1] = 1;
        for (int i = 2; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }
    }
    return result;
}