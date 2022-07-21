// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

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


int[,] ModMass(int[,] matrix)
{
    int count = 0;
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    while (count <= row * column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
                }
            }
        }
        count++;
    }
    return matrix;
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Первоначальная матрица: ");
Console.WriteLine();
int[,] mtrx_1 = MassNums(row, column, 1, 10);
Print(mtrx_1);
Console.WriteLine("Матрица с элементами, упорядоченными в порядке убывания: ");
Console.WriteLine();
int[,] mtrx_2 = ModMass(mtrx_1);
Print(mtrx_2);