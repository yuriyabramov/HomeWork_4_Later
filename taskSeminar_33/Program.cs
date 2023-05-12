/* Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */


Console.Clear();

int [] array = GetArray (6, -7, 9);
Console.WriteLine(String.Join (" ", array));

int numberFromUser = GetNumberFromUser ("Введите целое число: ", "Ошибка ввода!");

Console.WriteLine(CheckArrayForNumber(array, numberFromUser)? "да" : "нет");




#region 
// генерирует и выводит массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// запрашивает у пользователя ввод числа, которое будем проверять
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userNumberA))
            return userNumberA;

        Console.WriteLine(errorMessage);
    }
    
}

// проверяет наличие числа в массиве

bool CheckArrayForNumber (int[] array, int numberFromUser)
{
    foreach (int el in array)
    {
        if (el == numberFromUser)
        return true;
    }
    return false;

}

#endregion