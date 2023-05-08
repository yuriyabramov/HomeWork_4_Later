/* Напишите программу, которая принимает на вход число и выдаёт 
количество цифр в числе. Например: 456 -> 3; 78 -> 2; 89126 -> 5 */

int number = GetNumberFromUser("Enter a number: ", "Input error!");
int quantity = CountDigits(number);     // quantity- количество (англ.)
PrintReport(number, quantity);

#region Methods

// input

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
            if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else Console.WriteLine(errorMessage);
    }
    
}

// logic 

int CountDigits (int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

// output

void PrintReport(int number, int quantity)
{
    Console.WriteLine($"{number} -> {quantity}");
}

#endregion

