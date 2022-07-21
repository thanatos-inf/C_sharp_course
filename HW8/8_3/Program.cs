// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
// {
//     int row1 = matrix1.GetLength(0);
//     int column1 = matrix1.GetLength(1);
//     int row2 = matrix2.GetLength(0);
//     int column2 = matrix2.GetLength(1);
//     int prodRow = 0;
//     int prodColumn = 0;


//     int[,] prodMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++) 
//         prodMatrix[i] = matrix1[i] * matrix2[i];
//         (prodMatrix[j]) = (matrix1[j] * matrix2[j]);
//     }
//     return prodMatrix;
// }

// int[,] MultSquareMatrix (int[,] arr1, int[,] arr2)
// {
//     int length = arr1.GetLength(1);
//     int[,] matr = new int[length,length];

//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < length; j++)
//         {
//             for (int k = 0; k < length; k++)
//             {
//                 matr[i,j] = matr[i,j] + arr1[i,k] * arr2[k,j];
//             }

//         }
//     }
//     return matr;
// }

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
int[,] arr_2 = MassNums(row, column, 1, 10);
Print(arr_2);

// FindMinRow(arr_1);
// Print(arr_1);
Console.WriteLine("Произведением матриц является: ");