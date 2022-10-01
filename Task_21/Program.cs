/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Write("Введите A1: ");
double A1 = double.Parse(Console.ReadLine());
Console.Write("Введите A2: ");
double A2 = double.Parse(Console.ReadLine());
Console.Write("Введите A3: ");
double A3 = double.Parse(Console.ReadLine());
Console.Write("Введите B1: ");
double B1 = double.Parse(Console.ReadLine());
Console.Write("Введите B2: ");
double B2 = double.Parse(Console.ReadLine());
Console.Write("Введите B3: ");
double B3 = double.Parse(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(B1 - A1,2) + Math.Pow(B2 - A2,2) + Math.Pow(B3-A3,2));
{
    Console.WriteLine($"Расстояние между точками: {result}");
}