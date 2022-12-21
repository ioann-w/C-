/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

/*
1. Редлайн
2. цикл (счетчик)
3. вывод
*/

Console.Clear();
Console.Write("Введите любое число(числа): ");
var val = Console.ReadLine()?? "";

int[] arr = Array.ConvertAll(val.Split(","), int.Parse);

int morezero = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > 0) morezero++;
}

Console.WriteLine($"Чисел больше чем 0 = {morezero}");

