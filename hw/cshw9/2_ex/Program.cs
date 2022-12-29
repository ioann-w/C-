/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

Console.Write("Задайте значение M: ");
var val = Console.ReadLine() ?? "";
var M = int.Parse(val);
Console.Write("Задайте значение N: ");
val = Console.ReadLine() ?? "";
var N = int.Parse(val);

if (M > N)
{
    Console.WriteLine("Промежуток начального числа больше конечного.");
    return;
}

var sum = 0;

for (int i = M; i <= N; i++)
    sum += i;

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {sum}");

