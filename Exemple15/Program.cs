/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным. */

string[] WeekArray = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

 int GetNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

void WeekNumber(int number)
{
    if(number >= 1 && number <= 7)
    {
        if(number > 5)
        {
            Console.WriteLine("Это " + WeekArray[number - 1] + " ура выхоной");
        }
        else
        {
            Console.WriteLine("Это " + WeekArray[number - 1] + " пора на работу");
        }
    }
    else
    {
        Console.WriteLine("В неделе - семь дней");
    }
}

int number = GetNumber("Введите день недели --> ");
WeekNumber(number);