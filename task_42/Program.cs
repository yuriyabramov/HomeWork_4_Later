/* Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное. 45 -> 101101  3 -> 11   2 -> 10 */

Console.Clear();


int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
int result = GetConvert(number);
Console.WriteLine($"{number} -> {result}");


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

int GetConvert(int number)
{
    int p = 0; // номер степени десяти
    int result = 0;
    while (number > 0)
    {
        result = result + number % 2 * (int) Math.Pow (10, p);
        number = number / 2;
        p++;
    }
    return result;
}

