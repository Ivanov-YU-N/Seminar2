/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int Exemple(int number)
{
    int resalt = (number / 10) % 10;
    return resalt;
}

int number = new Random().Next(1, 1000);
Console.Write("Трехзначное число = ");
Console.WriteLine(number);
Console.Write("Вторая циффра числа = ");
Console.WriteLine(Exemple(number));