// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j], 6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] FillMatrix(int rowM, int columnN)
{
    double[,] matr = new double[rowM, columnN];
    Random num = new Random();

    for (int i = 0; i < rowM; i++)
    {
        for (int j = 0; j < columnN; j++)
        {
            matr[i, j] = Math.Round(num.NextDouble() * (10 + 11) - 10, 1);
        }
    }
    return matr;
}

double[,] matr_1 = FillMatrix(3, 3);
PrintMatrix(matr_1);
