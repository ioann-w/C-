/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

bool isCorrect = false;
int num = 0;

while (!isCorrect)
{
    Console.Write("Введите число: ");
    string value = Console.ReadLine () ?? "";

    if (int.TryParse(value, out num))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
            break;
        }

    int sum = 0;
    for (int i = 0; i < value.Length; i++)
        sum = sum + int.Parse(value[i].ToString());
    Console.WriteLine($"Сумма всех цифр числа {num}, равна {sum}");
}
