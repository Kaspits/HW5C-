/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
 */

//Инициализирует новый массив
int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 5);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] arr;
    int len = 0;
    if (array.Length % 2 == 0)
    {
        len = array.Length / 2;
        arr = new int[len];
    }
    else
    {
        len = array.Length / 2 + 1;
        arr = new int[len];
        arr[len - 1] = array[len];
    }

    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[i] = array[i] * array[array.Length - i - 1];
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine("Введите размер массива ");
int[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int[] arr = NewArray(array);
Console.WriteLine();
PrintArray(arr);
