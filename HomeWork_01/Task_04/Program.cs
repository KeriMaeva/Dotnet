// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 2;
int b = 3;
int c = 7;
int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);