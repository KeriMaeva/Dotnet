// Задача 13: Напишите метод, который выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

String ThirdNumber(int x)
{
    int thirdNumber = (x / 100) % 10;
    if (x > 99) { return thirdNumber.ToString(); }
    else return "Третьей цифры в числе нет";
}
Console.WriteLine(ThirdNumber(645));
Console.WriteLine(ThirdNumber(78));
Console.WriteLine(ThirdNumber(32679));