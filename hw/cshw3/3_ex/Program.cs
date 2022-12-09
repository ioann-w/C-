/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/



bool isCorrect = false;
int num = 0;

while (!isCorrect)
{
    Console.Write("Введите число: ");
    string strnum = Console.ReadLine() ?? "";

    if (int.TryParse(strnum, out num))
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Некорректное число");
        break;
    }

    
    Console.Write($"Таблица кубов чисел от 1 до {num}: ");
    
    for (int i = 1; i <= num; i++)
        Console.Write($"{Math.Pow(i, 3)}, ");

}

