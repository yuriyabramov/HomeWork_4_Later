/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
треугольник с сторонами такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон. */

Console.Clear();

int side1 = GetNumberFromUser("Введите сторону 1: ", "Ошибка ввода!");
int side2 = GetNumberFromUser("Введите сторону 2: ", "Ошибка ввода!"); 
int side3 = GetNumberFromUser("Введите сторону 3: ", "Ошибка ввода!");

bool result = IsExist(side1, side2, side3);

PrintReport(result);

#region Method 

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


// метод для проверки: может ли существовать такой треугольник
bool IsExist(int side1, int side2, int side3)
{
         return side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2;
}

// метод для вывода ответа
void PrintReport(bool detect)
{
    if (result == true)
        Console.WriteLine("Да");
    else 
        Console.WriteLine("Нет");
}

#endregion