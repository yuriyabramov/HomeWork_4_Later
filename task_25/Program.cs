/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
 в натуральную степень B. Например: 3, 5 -> 243 (3⁵); 2, 4 -> 16 */


/* int A = new Random(). Next (2, 7);
int B = new Random(). Next (2, 7);

Console.WriteLine($"{A}, {B} -> {Math.Pow (A, B)} ");*/


//////////////////////////////////////////////////////////////////////////////////


int A = GetNumberFromUserA ("Введите целое число A: ", "Ошибка ввода!");
int B = GetNumberFromUserB ("Введите целое число B: ", "Ошибка ввода!"); 
ToDegree(A, B);

// int C = Convert.ToInt32 (Math.Pow (A, B));      ----> 18 и 19 строками можно заменить 16
// PrintReport(A, B, C);                           ----> 18 и 19 строками можно заменить 16





#region Methods

// input

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

// logic

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// output

/*void PrintReport(int A, int B, int C)
{
    Console.WriteLine($"{A}, {B} -> {C}");
} */

#endregion