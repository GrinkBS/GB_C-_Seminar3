// Задача 20

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x");
int xA = Convert.ToInt32(Console.ReadLine()); // double xA = Conver.ToDouble(Console.ReadLine()); - чтобы завести все с десятичными, еси надо
Console.WriteLine("y");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z");
int zB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
Console.WriteLine($"{result:f2}");