// ReadLine - позволяет водить данные из терминала
Console.Write("Введите ваше имя: ");
string username = Console.ReadLine() ?? "";
Console.Write("Привет, ");
Console.Write(username + "!");