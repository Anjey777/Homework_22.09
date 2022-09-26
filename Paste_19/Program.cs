/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if ((number/100==number%10*10+number%100/10)) 
Console.Write("ДА!");
else
    Console.Write("НЕТ");

