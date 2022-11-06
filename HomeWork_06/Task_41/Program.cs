/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

int Recursion(int m, int count)
{
    if (m > 0)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count = count + 1;
            return Recursion(m - 1, count);
        }
        else return Recursion(m - 1, count);
    }
    else return count;
}
Console.WriteLine($"Пользователь ввёл {Recursion(5, 0)} чисел больше ноля");
