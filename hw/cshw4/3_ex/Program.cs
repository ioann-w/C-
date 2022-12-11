/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


int[] eightnum = new int[8];

Random randomnum = new Random();

Console.Clear();
Console.WriteLine("Элементы массива: ");
Console.WriteLine("");

for (int i = 0; i < eightnum.Length; i++)
{
    eightnum[i] = randomnum.Next();

    Console.WriteLine(eightnum[i]);
    Console.WriteLine("");
}