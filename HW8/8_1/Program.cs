// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.




int[,] ModMass (int[,] arr)
{
    int count = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    while (count <= row*column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column-1; j++)
            {
                if (arr[i,j] < arr[i,j+1]) 
                {
                    (arr[i,j], arr[i,j+1]) = (arr[i,j+1], arr[i,j]);
                }
            }
        }
        count++;
    }
    return arr;
}