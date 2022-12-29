/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Clear();

int[,] GetArr(int a, int b)
{
    int[,] arr = new int[a, b];
    
    int n = 1;
    int q = 0;

    while (n <= a * b)
    {
        for (int j = q; j < b - q; j++)
        {
            int i = q;
            arr[i, j] = n;
            n++;
        }
        if(n > a*b) break;
        for (int i = 1 + q; i < a - q; i++)
        {
            int j = (b - 1) - q;
            arr[i, j] = n;
            n++;
        }
        for (int j = (b - 2) - q; j >= 0 + q; j--)
        {
            int i = (a - 1) - q;
            arr[i, j] = n;
            n++;
        }
        for (int i = (a - 2) - q; i > 0 + q; i--)
        {
            int j = q;
            arr[i, j] = n;
            n++;
        }
        q++;
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
}

int a = 10;
int b = 5;
int[,] newArray = GetArr(a, b);
PrintArray(newArray);