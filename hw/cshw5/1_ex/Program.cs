/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

bool isCorrect = false;
int num = 0;

while (!isCorrect)
{
    Console.Write("Задайте размер массива: ");
    var val = Console.ReadLine () ?? "";

    if (int.TryParse(val, out num))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ошибка, размер задается числом.");
            break;
        }
}

int[] arr = new int[num];
Random rnd = new();
int ctrlval = 0;

for (int i = 0; i < num; i++)
    arr[i] = rnd.Next(100, 999);

for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i] % 2) == 0) ctrlval++;
}

Console.Write($"Количество чётных чисел в массиве - равняется {ctrlval}.");