//Функция:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

//Массив:

int[] array = {10, 21, 30, 41, 50, 69, 7, 18, 9};

/*
array[0] = 12; //Записать значение в массив
Console.WriteLine(array[0]); //Обращение к элементу массива
*/

int max = Max(
    Max(array[0], array[1], array [2]),
    Max(array[3], array[4], array [5]),
    Max(array[6], array[7], array [8])
);

Console.Write("Максимальное число массива array - " + max);