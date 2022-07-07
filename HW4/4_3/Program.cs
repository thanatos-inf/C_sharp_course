// Напишите программу, которая задаёт массив из 8 элементов
// случайными числами и выводит их на экран.

int[] fillArray(int size)
{       
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);        
    }    
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] new_array = fillArray(8);
PrintArray(new_array);