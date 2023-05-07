/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму
чисел от 1 до А. Например: 4 -> 10 (1+2+3+4=10); 7 -> 28; 8 -> 36*/

int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");

int sumNumbers = GetSumNumbers(num);

PrintReport(num, sumNumbers);

////////////////////////////////
#region Мои методы ввода-вывода


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



int GetSumNumbers(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number;
        number --;
    }

    return sum;
}



void PrintReport(int num, int number)
{
    Console.WriteLine($"{num}-> {number}");
}

#endregion
