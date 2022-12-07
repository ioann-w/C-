// int - целые числа
// new Random().Next(1, 10) - присваивает случайные числа из выбранного диапозона, например от 1 до 10
int numberA = new Random().Next(1, 10);
Console.WriteLine("Первое число = " + numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine("Второе число = " + numberB);
int result = numberA + numberB;
Console.WriteLine(result);