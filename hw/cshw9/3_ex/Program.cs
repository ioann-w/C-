/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.Clear();

Console.Write("Задайте значение M: ");
var val = Console.ReadLine() ?? "";
var M = int.Parse(val);
Console.Write("Задайте значение N: ");
val = Console.ReadLine() ?? "";
var N = int.Parse(val);

int fAc(int N, int M)
{
    while (N != 0)
    {
        if (M == 0)
            M = 1;
        else
            M = fAc(N, M - 1);
        N--;
    }
    return M + 1;
}

Console.WriteLine($"Вычисления функции Аккермана({M},{N}) = " + fAc(M, N));
