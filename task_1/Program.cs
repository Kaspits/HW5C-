/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

//Инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }

    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получает сумму положительных элем. в массиве
int GetPositiveSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            summ += arr[i];
        }
    }
    return summ;
}

//получает сумму отрицательных элем. в массиве
int GetNegativeSumm(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            summ += arr[i];
        }
    }
    return summ;
}

// кортеж
(int, int) GetPositiveandNegativeSumm(int[] array)
{
    int positive = 0;
    int negative = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positive += array[i];
        }
        else
        {
            negative += array[i];
        }
    }

    return (positive, negative);
}

int[] arr = InitArray(12);
PrintArray(arr);
int positiveSumm = GetPositiveSumm(arr);
int negativeSumm = GetNegativeSumm(arr);

//Кортеж запуск
(int pos, int neg) = GetPositiveandNegativeSumm(arr);

Console.WriteLine($"Сумма положительных: {positiveSumm}. Сумма отрицательных: {negativeSumm}");

Console.WriteLine($"Сумма положительных: {pos}. Сумма отрицательных: {neg}");
