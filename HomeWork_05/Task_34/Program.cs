/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2   */

int[] NewArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}
int Even(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            n++;
        }
    }
    return n;
}
int[] array = NewArray(10);
int N = Even(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве: " + N);