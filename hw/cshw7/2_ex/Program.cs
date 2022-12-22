/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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
        Console.Write($"  {arr[i, j]}  ");
    Console.WriteLine();
}

Console.Write("Введите позицию строки: ");
var x = Convert.ToInt32(Console.ReadLine()?? "");

Console.Write("Введите позицию стобца: ");
var y = Convert.ToInt32(Console.ReadLine()?? "");

if ((x >= arr.GetLength(0)) || (y >= arr.GetLength(1)))
{
    Console.WriteLine($"Элемента с позицией [{x},{y}] в массиве нет.");
    return;
}

Console.WriteLine($"Элемент с позицией [{x},{y}] имеет значение {arr[x,y]}.");

