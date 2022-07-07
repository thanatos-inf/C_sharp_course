// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int SumNum(int[] arr)
{
    int oddSum = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        oddSum = oddSum + arr[i];
    }
    return oddSum;
}

int[] arr_1 = MassNums(6);
Print(arr_1);
Console.WriteLine(SumNum(arr_1));