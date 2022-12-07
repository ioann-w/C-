//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine() ?? "");

if (num > 100)
{
    string strNum = Convert.ToString(num);
    Console.WriteLine("В числе " + strNum + ", третья цифра: " + strNum[2]);
}

else
{
    Console.WriteLine("В числе, нет 3ей цифры");
}