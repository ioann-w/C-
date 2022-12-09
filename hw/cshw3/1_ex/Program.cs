/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int Palindromforfive(string message)
{
    bool isCorrect = false;
    int num = 0;


    while(!isCorrect)
    {
        Console.Write(message);
        string numbers = Console.ReadLine() ?? "";

        if (int.TryParse(numbers, out num) && num > 9999 && num < 99999)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректное число");
            break;
        }

        if (numbers[0] == numbers[4] && numbers[1] == numbers [3])
        {
            Console.WriteLine($"{numbers} - является палиндромом");
        }
        else
        {
            Console.WriteLine($"{numbers} - не является палиндромом");
        }
        
    }
    
    return num;

}

Palindromforfive("Введите пятизначное число: ");