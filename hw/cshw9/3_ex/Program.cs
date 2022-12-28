/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
Console.Write("Введите m: ");
var str = Console.ReadLine() ?? "";
var m = int.Parse(str);
Console.Write("Введите n: ");
str = Console.ReadLine() ?? "";
var n = int.Parse(str);

static int Ack(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = Ack(n, m - 1);
        n--;
    }
    return m + 1;
}

Console.WriteLine($"Функция Аккермана, где m = {m}, n = {n} равна: " + Ack(m, n));
*/

