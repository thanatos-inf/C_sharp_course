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
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    
    if(rowPos > row || columnPos > column)
        return $"[{rowPos}, {columnPos}] => такого числа в массиве нет";
    return $"Искомое число с позицией: [{rowPos}, {columnPos}] = {array[rowPos -1, columnPos -1]}";
}

int[,] arr_1 = MassNums(4, 4, 1, 10);
Print(arr_1);
Console.WriteLine(FindElement(arr_1, 3, 3));
Console.WriteLine(FindElement(arr_1, 1, 7));
