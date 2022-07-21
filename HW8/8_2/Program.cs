// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void FindMinRow(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int minSum = 1000;
    int minRow = 0;

    for (int i = 0; i < row; i++)
    {
        int elSum = 0;
        for (int j = 0; j < column; j++) elSum += array[i, j];
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

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
FindMinRow(arr_1);
