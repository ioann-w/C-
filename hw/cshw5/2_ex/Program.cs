/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

bool isCorrect = false;
int num = 0;

while(!isCorrect)
{
    Console.WriteLine("Задайте размер массива: ");
    var val = Console.ReadLine()?? "";
    if(int.TryParse(val, out num))
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Неверно указано число.");
    }
}

int[] arr = new int[num];
Random rnd = new();
int sum = 0;

for (int i = 0; i < num; i++)
    arr[i] = rnd.Next(0, 1000);

for (int i = 1; i < arr.Length; i+=2)
    sum += arr[i];

Console.Write($"Сумма элементов, стоящих на нечётных позициях - равна {sum}");