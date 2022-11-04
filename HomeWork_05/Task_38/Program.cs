/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76   */

double[] NewArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100;
    }
    return array;
}
double Dif(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double dif = max - min;
    return dif;
}
double[] array = NewArray(5);
double dif = Dif(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0:F0} ", array[i]);
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива: "+ "{0:F0} ", dif);
