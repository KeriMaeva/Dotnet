// Задача 19: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

int GetData(string text)
{
    int v = -1;
    bool flag = false;
    while (!(flag && v > 9999 && v < 100000))
    {
        Console.Write(text);
        string data = Console.ReadLine();
        flag = int.TryParse(data, out v);
    }
    return v;
}
bool Palindrome(int number)
{
    if (number % 10 == number / 10000 && (number / 10) % 10 == (number / 1000) % 10) 
    return true;
    else return false;
}

if (Palindrome(GetData("Введите пятизначное число: ")))
{
    System.Console.WriteLine("Число является полиндромом");
}
else System.Console.WriteLine("Число не является полиндромом");
