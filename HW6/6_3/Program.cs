// Напишите программу, которая будет создавать копию заданного двумерного массива 
// с помощью поэлементного копирования.


void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] FillMatrix(int row, int column)
{
    double[,] matr = new double[row, column];
    Random num = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matr[i, j] = Math.Round(num.NextDouble() * (100 + 101) - 100, 2);
        }
    }
    return matr;
}

double[,] CopyMatrix(double[,] matr)
{
    double[,] new_matr = new double[matr.GetLength(0), matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            new_matr[i, j] = matr [i, j];
        }
    }
    return new_matr;
}

double[,] matr_1 = FillMatrix(3, 3);
PrintMatrix(matr_1);
double[,] matr_1_copy = CopyMatrix(matr_1);
PrintMatrix(matr_1_copy);