/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
var a = Convert.ToInt32(Console.ReadLine()?? "");

Console.Write("Введите количество столбцов в массиве: ");
var b = Convert.ToInt32(Console.ReadLine()?? "");

int[,] arr = new int[a, b];
Random rnd = new ();

for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }

Console.WriteLine("Массив сгенерирован: ");

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
        Console.Write($" {arr[i, j]}   ");
    Console.WriteLine();
}

var rows = arr.GetLength(0);
var columns = arr.GetLength(1);

int [] columnsSum = new int[columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        columnsSum[j] += arr[i,j];
}

for (int i = 0; i < columns; i++)
    Console.Write("=====");
Console.WriteLine();

for (int i = 0; i < columns; i++)
    Console.Write($" {(double)columnsSum[i] / rows} ");
Console.Write(" Среднее арифметическое каждого столбца");
Console.WriteLine();
Console.WriteLine();
