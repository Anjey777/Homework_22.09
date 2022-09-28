/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if (number == int.Parse(new string(number.ToString().Reverse().ToArray())))
    Console.WriteLine($"ДА! {number} - это палиндром");
else
    Console.WriteLine($"НЕТ! {number} - это не палиндром");