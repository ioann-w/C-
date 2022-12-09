/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Вводим xyz
Console.WriteLine("Введите координаты первой точки: ");

Console.Write("Чему равен x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Чему равен y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Чему равен z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Введите координаты второй точки: ");

Console.Write("Чему равен x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Чему равен y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Чему равен z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine($"Координаты первой точки - {x1}, {y1}, {z1} | {x2}, {y2}, {z2} - Координаты второй точки");
Console.WriteLine(" ");


//Считаем расстояние в 3D
var result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

Console.WriteLine($"Расстояние между координат двух точек в 3D пространстве - {result}");
Console.WriteLine(" ");