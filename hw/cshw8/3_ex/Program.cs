/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,4:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] MultArrays (int[,] a, int[,] b)
{
    var dim0 = a.GetLength(0);
    var dim1 = b.GetLength(1);
    if (dim0 != dim1)
    {
        Console.WriteLine("Массивы не согласованы");
        Environment.Exit(0);
    }

    int[,] c = new int[dim0, dim1];

    for (int i = 0; i < dim0; i++)
        for (int j = 0; j < dim1; j++)
            for (int x = 0; x < a.GetLength(1); x++)
                c[i, j] += a[i, x] * b[x, j];

    return c;
}

int[,] arr0 =
{
    { 2, 4 },
    { 3, 2 }
};

int[,] arr1 =
{
    { 3, 4 },
    { 3, 3 }
};

Console.WriteLine("Первая матрица:");
PrintArray(arr0);
Console.WriteLine("Вторая матрица:");
PrintArray(arr1);
Console.WriteLine("Результат произведения матриц:");
PrintArray(MultArrays(arr0, arr1));
*/

Console.Clear();

int [,] GetArr(int rows, int columns)  
{ 
    Random rnd = new Random(); 
    int [,] arr = new int [rows,columns]; 
    for (int i = 0; i < arr.GetLength(0); i++) 
        for (int j = 0; j < arr.GetLength(1); j++) 
            arr[i,j] = rnd.Next(0, 5); 
    return arr;    
} 

void PrintArray (int [,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
            Console.Write($"{arr[i,j]}\t"); 
    Console.WriteLine();     
    }  
} 

int [,] ResultArr(int [,] fArr, int [,] sArr)
{
    int a = fArr.GetLength(0);
    int b = sArr.GetLength(1);
    int c = fArr.GetLength(1);
    int [,] arr = new int [a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = 0;
            for (int k = 0; k < c; k++)
            {
                arr[i, j] += fArr[i, k] * sArr[k, j];
            }
        }
    }
    


    return arr;
}



int a = 2; 
int b = 4; 
int [,] fArr = GetArr(a,b); 
int [,] sArr = GetArr(b,a); 
Console.WriteLine("Матрица 1:");
PrintArray(fArr);
Console.WriteLine("Матрица 2:");
PrintArray(sArr);
Console.WriteLine("Произведение Матрицы:");
int [,] newArray = ResultArr(fArr, sArr);
PrintArray(newArray);