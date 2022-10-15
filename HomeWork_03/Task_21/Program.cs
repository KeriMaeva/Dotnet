// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}
void Print(double ax, double ay, double az, double bx, double by, double bz, double result)
{
    string output = "A (" + ax + "," + ay + "," + az + "); B (" + bx + "," + by + "," + bz + "), -> " + Math.Round(result, 2);
    Console.WriteLine(output);
}
double GetDistance(double ax, double ay, double az, double bx, double by, double bz)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double z = Math.Pow(az - bz, 2);
    double result = Math.Sqrt(x + y + z);
    return result;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double az = GetValue("az");
double bx = GetValue("bx");
double by = GetValue("by");
double bz = GetValue("bz");
double distance = GetDistance(ax, ay, az, bx, by, bz);
Print(ax, ay, az, bx, by, bz, distance);