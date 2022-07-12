// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    Random num = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(num.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}


void MinMaxNum(double[] arr)
{
    double MaxNum = arr[0];
    double MinNum = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > MaxNum) MaxNum = arr[i];
        else if (arr[i] < MinNum) MinNum = arr[i];
    }
    Console.WriteLine($"Максимальное число: {MaxNum}, минимальное число: {MinNum}. ");
    Console.WriteLine($"Разность чисел: {MaxNum} - ({MinNum}) = {Math.Round(MaxNum - MinNum, 2)}");
}


double[] arr_1 = MassNums(6);
Print(arr_1);
MinMaxNum(arr_1);

// Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2)
// Random n_new = new Random();
