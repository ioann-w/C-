// Поиск элемента в массиве

int[] array = {1, 2, 3, 4, 5, 69, 7, 8, 9, 0};

int n = array.Length; //Длина массива
int find = 69;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Необходимое число имеет индекс - " + index);
        break; //Останавливает выполнение цикла
    }
    index++;
}