// Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string text)
{
    Console.Write(text + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int[] GetPow(int n)
{
    int[] squares = new int[n];
    for (int i = 0; i < n; i++)
    {
        squares[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return squares;
}
int n = GetNumber("Введите число");
System.Console.Write(n + " -> ");
System.Console.WriteLine(String.Join(' ', GetPow(n)));