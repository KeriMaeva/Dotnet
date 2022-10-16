// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string text)
{
    Console.Write(text + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int GetSum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}
void Print(int a, int result)
{
    string output = a + " -> " + result;
    Console.WriteLine(output);
}
int a = GetNumber("Введите число");
int result = GetSum(a);
Print(a, result);