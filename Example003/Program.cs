/* Задача 3: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

double[] IntRendArr(int quantity, int MinNumber, int MaxNumber) // Запись случайных чисел от Min до Max в массив определённой длины. Max входит в диапазон.
{
    double[] arrey = new double[quantity];

    for (int i = 0; i < quantity; i++)
    {
        arrey[i] = new Random().Next(MinNumber, MaxNumber + 1);
    }
    return arrey;
}

void PrintArr(double[] array, int sign) // Вывод массива в консоль в виде [66,1,19,73,48,13,50,25], если sign = 0 конец массива начинается с новой строки, если sign = 1 то строка продолжается
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

double subMaxMinArray(double[] array) // Нахождение разницы между максимальным и минимальным элементом массива
{
    int i = 0;
    double min = array[i];
    double max = array[i];

    while (i < array.Length)
    {

        if (array[i] < min) min = array[i];
       
        if (array[i] > max)  max = array[i];

        i++;
    }

    return max - min;
}


double[] myArray = IntRendArr(new Random().Next(3, 10), 1, 100);

PrintArr(myArray, 0);

Console.WriteLine($"Разница между максимальным и минимальным числом в массиве равняется {subMaxMinArray(myArray)}");