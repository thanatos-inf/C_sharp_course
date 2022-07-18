// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

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

string FindElement(int [,] array, int rowPos, int columnPos)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int row = array.GetLength(0);
        int column = array.GetLength(1);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i < array.GetLength(0) && j < array.GetLength(1)) 
            Console.WriteLine(array[rowPos -1, columnPos -1]);
            return;
        }
    }
    Console.WriteLine($"{rowPos}, {columnPos} => такого числа в массиве нет");
}

int[,] arr_1 = MassNums(4, 4, 1, 10);
Print(arr_1);
FindElement(arr_1, 4, 4);