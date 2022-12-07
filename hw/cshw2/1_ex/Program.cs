//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
//Решение через терминал(в лоб):

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num % 100) / 10;

Console.WriteLine(result);
*/


//Решение методом:

void Only2nd(int num)
{
    int result = (num % 100) / 10;
    Console.WriteLine($"Второе число из {num} - {result}");
}

Only2nd(123);