﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y");
int yB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
Console.WriteLine(result);