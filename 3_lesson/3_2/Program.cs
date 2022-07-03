// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.

double Roots(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine(Roots(3, 2, 6, 1));
Console.WriteLine(Roots(7, 1, -5, -1));