/* Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.Например: 452 -> 11; 82 -> 10   */


int number = GetNumberFromUser("Enter a number: ", "Input error!");
int sum = SumAllDigit(number);     
PrintReport(number, sum);


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

int SumAllDigit (int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

// output

void PrintReport(int number, int sum)
{
    Console.WriteLine($"{number} -> {sum}");
}

#endregion

