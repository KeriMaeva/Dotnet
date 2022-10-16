// Задача 25: опишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без math.pow

int GetNumber(string text)
{
    Console.Write(text + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int GetPow(int a, int b)
{
    int pow = a;
    for (int i = 2; i <= b; i++)
    {
        pow = pow * a;
    }
    return pow;
}
void Print(int a, int b, int result)
{
    string output = a + ", " + b + " -> " + result;
    Console.WriteLine(output);
}
int a = GetNumber("Введите число A");
int b = GetNumber("Введите число B");
int result = GetPow(a, b);
Print(a, b, result);