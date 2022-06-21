/*
Задача 1: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
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

int positiveNumbersArray(int [] array) // Нахождение чётных элементов в массиве и вывод их количества 

{
    int sum = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            sum++;
        }
    }
return sum;
}


int [] myArray = IntRendArr(new Random().Next(3,10),0,999);

PrintArr(myArray,0);

Console.WriteLine($"Количество чётных чисел в массиве {positiveNumbersArray(myArray)}");

