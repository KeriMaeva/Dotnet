/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет  */


int[,] array = new int[5, 5];

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

Console.WriteLine("Введите две позиции элемента в двумерном массиве");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > array.GetLength(0) - 1 || b > array.GetLength(1) - 1)
    Console.WriteLine("Такого элемента в двумерном массиве нет");
else
{
    object c = array.GetValue(a, b);
    Console.WriteLine("Элемент на позиции [" + a + "," + b + "] = " + c);
}