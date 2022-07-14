// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Dot(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1) / (k2 - k1), 3);
    double y = Math.Round(k1 * x + b1, 3);
    Console.WriteLine($"Координаты точки пересечения прямых: ({x};{y})");
}

Dot(3, 4, 6, 8);