// Задача 15: Напишите метод, который принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

String WeekDay(int x)
{
    if (x < 6) return x + " день недели является рабочим";
    if (x < 8) return x + " день недели является выходным";
    else return x + " день не является днем недели";
}
Console.WriteLine(WeekDay(6));
Console.WriteLine(WeekDay(7));
Console.WriteLine(WeekDay(1));