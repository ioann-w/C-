/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

float[] arr = new float[num];
Random rnd = new();

for (int i = 0; i < num; i++)
    arr[i] = (float)(rnd.Next(1, 1000) + rnd.NextDouble());

float maxNum = arr[0];
float minNum = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] > maxNum) maxNum = arr[i];
    if(arr[i] < minNum) minNum = arr[i];
}

Console.Write($"Разница между {maxNum} и {minNum} - равняется {maxNum - minNum}");