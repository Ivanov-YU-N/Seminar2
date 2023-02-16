/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. */

int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ThirdNumber(int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool CheckNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
    
}

int number = GetNumber("Введите число = ");
if(CheckNumber(number))
{
    Console.WriteLine(ThirdNumber(number));
}