//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Daysoftheweek (int arg)
    {
        switch (arg)
        {
            case 1:
                Console.WriteLine("Понедельник, рабочий день");
                break;
            case 2:
                Console.WriteLine("Вторник, рабочий день");
                break;
            case 3:
                Console.WriteLine("Среда, рабочий день");
                break;
            case 4:
                Console.WriteLine("Четверг, рабочий день");
                break;
            case 5:
                Console.WriteLine("Пятница, рабочий день");
                break;
            case 6:
                Console.WriteLine("Суббота, выходной день!");
                break;
            case 7:
                Console.WriteLine("Воскресение, выходной день!");
                break;
            default:
                Console.WriteLine("Неверно указанно число ввода (Дни недели указываются от 1-7)");
                break;                
        }
    }


Daysoftheweek (7);