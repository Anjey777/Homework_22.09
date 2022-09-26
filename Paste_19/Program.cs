/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
int returnNumber = 0;
while (number != 0)
{
    returnNumber = (returnNumber * 10) + (number % 10);
    number/=10;
}
if (number==returnNumber) 
Console.Write("ДА!");
else
    Console.Write("НЕТ");