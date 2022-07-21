// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] matrix)
{
    int row_size = matrix.GetLength(0);
    int column_size = matrix.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(from, to);
        }
    }
    return matrix;
}

int[,] MatrixProduct(int[,] matr1, int[,] matr2)
{
    int length = matr1.GetLength(0);
    int[,] newMatr = new int[length, length];

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                newMatr[i, j] = newMatr[i, j] + matr1[i, k] * matr2[k, j];
            }

        }
    }
    return newMatr;
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Первоначальные матрицы: ");
int[,] mtrx_1 = MassNums(row, column, 1, 10);
Print(mtrx_1);
int[,] mtrx_2 = MassNums(row, column, 1, 10);
Print(mtrx_2);

Console.WriteLine("Произведением матриц является: ");
int[,] newMtrx = MatrixProduct(mtrx_1, mtrx_2);
Print(newMtrx);