// Задача 10: Напишите метод, который принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumber(int x)
{
    int secondNumber = (x / 10) % 10;
    return secondNumber;
}
Console.WriteLine(SecondNumber(456));
Console.WriteLine(SecondNumber(782));
Console.WriteLine(SecondNumber(918));
