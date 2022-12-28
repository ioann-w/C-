/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

var summList = new List<int>();

for (int i = 0; i < arr.GetLength(0); i++)
{
    var sum = Enumerable.Range(0, arr.GetUpperBound(1) + 1).Sum(x => arr[i, x]);
    summList.Add(sum);
}

var x = summList.Select((item, index) => (item, index)).Min().index + 1;

Console.WriteLine("В массиве");
PrintArray(arr);
Console.WriteLine($"Минимальную сумму имеет строка номер: {x}");
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

int GetSum(int [,] arr)  
{  
    int minSum = 0;
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minSum += arr[0, i];
    }
    Console.WriteLine($"Строка {1}, сумма элементов {minSum}");

    for (int i = 1; i < arr.GetLength(0); i++) 
    {   
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            sum += arr[i, j];
        } 
        Console.WriteLine($"Строка {i + 1}, сумма элементов {sum}");
        if(sum < minSum)
        {
            minSum = sum;
            minIndex = i;
        }
    }
            
    return minIndex + 1;
}

Console.WriteLine("Массив сгенерирован: ");
PrintArr(arr);
int minSum = GetSum(arr);
Console.WriteLine($"Строка с минимальной суммой: {minSum}");
