// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
// столбце.

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

void Average(int [,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    Console.WriteLine("Среднее арифметическое каждого столбца: ");       
    for (int i = 0; i < column; i++)
    {
        double AvResult = 0;
        for (int j = 0; j < row; j++) AvResult = AvResult + array[j, i];
        Console.Write($"{Math.Round(AvResult / row, 2)};  ");
    }  
}

int[,] arr_1 = MassNums(4, 5, 1, 10);
Print(arr_1);
Average(arr_1);
