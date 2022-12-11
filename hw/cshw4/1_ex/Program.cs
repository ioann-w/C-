/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


/* Не совсем понял условия задачи, зачем цикл? 
В смысле, нужно было сделать чтобы программа бесконечно просила вводить новые
числа после того как завершила первую итерацию ? */

bool isCorrect = false;
int num1 = 0;
int num2 = 0;

while (!isCorrect)
{
    Console.Write("Введите первое число: ");
    string strnum1 = Console.ReadLine() ?? "";

    Console.WriteLine("");

    if (int.TryParse(strnum1, out num1))
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Некорректное число");
    }
    
    Console.Write("Введите второе число: ");
    string strnum2 = Console.ReadLine() ?? ""; 
      
    if (int.TryParse(strnum2, out num2))
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Некорректное число");
    }
        Console.Clear();
        Console.WriteLine($"{num1} в степени {num2} = {Math.Pow(num1, num2)}");
}