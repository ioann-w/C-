/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
1.Редлайн х4
Уровнение по формуле
Вывод
*/

Console.Clear();

Console.Write("Введите значение a1: ");
int a1 = Convert.ToInt32(Console.ReadLine()?? "");
Console.Write("Введите значение b1: ");
int a2 = Convert.ToInt32(Console.ReadLine()?? "");
Console.Write("Введите значение a2: ");
int b1 = Convert.ToInt32(Console.ReadLine()?? "");
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine()?? "");

Console.WriteLine("");

double x = (double)(a1 - b1) / (a2 - b2) * -1;  //Я так понимаю - это формула
double y = b2 * x + b1;                         //Другой формулы не нашел

Console.WriteLine($"Координаты точки пересечения двух прямых: ({x}; {y})");

