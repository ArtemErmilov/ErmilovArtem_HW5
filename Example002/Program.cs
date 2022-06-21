/*
Задача 2: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
*/
int[] IntRendArr(int quantity, int MinNumber, int MaxNumber) // Запись случайных чисел от Min до Max в массив определённой длины. Max входит в диапазон.
{
    int[] arrey = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        arrey[i] = new Random().Next(MinNumber, MaxNumber + 1);
    }
    return arrey;
}

void PrintArr(int[] array, int sign) // Вывод массива в консоль в виде [66,1,19,73,48,13,50,25], если sign = 0 конец массива начинается с новой строки, если sign = 1 то строка продолжается
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1)) Console.Write(array[i] + ",");
        if ((i == (array.Length - 1)) && (sign == 0))
        {
            Console.WriteLine(array[i] + "]");
        }
        if ((i == (array.Length - 1)) && (sign == 1))
        {
            Console.Write(array[i] + "]");
        }
    }
}


int sumOddPositionsArray(int[] array)// Нахождение суммы элементов массива, стоящих на нечётных позициях

{

    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum +=array[i];
    }
    return sum;
}


int[] myArray = IntRendArr(new Random().Next(3, 10), 0, 10);

PrintArr(myArray, 0);

Console.WriteLine($"Сумма чётных чисел в массиве равна {sumOddPositionsArray(myArray)}");