/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] NewArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-99, 100);
    }
    return array;
}
int SumEven(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            n = n + array[i];
        }
    }
    return n;
}
int[] array = NewArray(4);
int Sum = SumEven(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + Sum);