/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}
Console.WriteLine("Задан двумерный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}
for (int i = 0; i < array.GetLength(1); i++)
{
    int srAr = 0;
    int ColChetn = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        srAr += array[j, i];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(double)srAr / array.GetLength(0)}");
}
