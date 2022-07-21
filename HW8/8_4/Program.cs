// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindMinEl(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int minNum = matrix[0, 0];
    int[] minIndex = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (matrix[i, j] < minNum)
            {
                minNum = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
    }
    Console.WriteLine();
    Console.WriteLine(matrix[minIndex[0], minIndex[1]]);
    return minIndex;
}

void minusRowColumn(int[,] matr, int[] minIndx)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (minIndx[0] == i || minIndx[1] == j) continue;
            else Console.Write($" {matr[i, j], 1} ");
            Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine("Первоначальная матрица: ");
Console.WriteLine();
int[,] mtrx_1 = MassNums(row, column, 1, 10);
Print(mtrx_1);
Console.Write("Значение минимального элемента: ");
int[] MinimumIndex = FindMinEl(mtrx_1);
Console.WriteLine();
Console.WriteLine("Результат: ");
minusRowColumn(mtrx_1, MinimumIndex);
