/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
 в натуральную степень B. Например: 3, 5 -> 243 (3⁵); 2, 4 -> 16 */


/* int A = new Random(). Next (2, 7);
int B = new Random(). Next (2, 7);

Console.WriteLine($"{A}, {B} -> {Math.Pow (A, B)} ");*/


//////////////////////////////////////////////////////////////////////////////////


int A = GetNumberFromUserA ("Введите целое число A: ", "Ошибка ввода!");
int B = GetNumberFromUserB ("Введите целое число B: ", "Ошибка ввода!"); 

int C = Convert.ToInt32 (Math.Pow (A, B));

PrintReport(A, B, C);

#region 

int GetNumberFromUserA(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userNumberA))
            return userNumberA;

        Console.WriteLine(errorMessage);
    }
    
}


int GetNumberFromUserB(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userNumberB))
            return userNumberB;

        Console.WriteLine(errorMessage);
    }
    
}


void PrintReport(int A, int B, int C)
{
    Console.WriteLine($"{A}, {B} -> {C}");
}

#endregion