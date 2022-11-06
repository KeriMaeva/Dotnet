/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   */

double GetKoor(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}
double CalcX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double CalcY(double b1, double k1, double b2, double k2)
{
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    return y;
}
void Print(double x, double y)
{
System.Console.WriteLine($"Прямые пересекаются в координатах х = {x} и у = {y}");
}
double b1 = GetKoor("Введите координату b1");
double k1 = GetKoor("Введите координату k1");
double b2 = GetKoor("Введите координату b2");
double k2 = GetKoor("Введите координату k2");
double x = CalcX(b1, k1, b2, k2);
double y = CalcY(b1, k1, b2, k2);
Print(x, y);