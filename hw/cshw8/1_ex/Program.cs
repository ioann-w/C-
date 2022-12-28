/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void PrintArr (int [,] arr)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
            Console.Write($" {arr[i, j]}   ");
        Console.WriteLine();
    }
}

int [,] SortArr(int [,] arr)  
{   
    int a = arr.GetLength(0);
    int b = arr.GetLength(1);

    for (int i = 0; i < a; i++) 
    {
        for (int k = 0; k < b - 1; k++)
        {
            for (int j = 0; j < b - 1; j++) 
            {
                if(arr[i, j] < arr[i, j + 1])
                {
                    int result = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = result;
                }
            } 
        }
    }
            
    return arr;    
}

Console.WriteLine("Массив сгенерирован: ");
PrintArr(arr);
Console.WriteLine("Массив отсортирован: ");
int [,] ArrOk = SortArr(arr);
PrintArr(ArrOk);
