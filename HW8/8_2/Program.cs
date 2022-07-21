// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

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

void FindMinRow(int[,] matr)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    int minSum = 1000;
    int minRow = 0;

    for (int i = 0; i < row; i++)
    {
        int elSum = 0;
        for (int j = 0; j < column; j++) elSum += matr[i, j];
        Console.Write($"{elSum}; ");
        if (elSum < minSum)
        {
            minSum = elSum;
            minRow = i+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов составляет {minSum} и находится в строке {minRow}.");
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] mtrx_1 = MassNums(row, column, 1, 10);
Print(mtrx_1);
FindMinRow(mtrx_1);
