﻿// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет

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
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

void SomeNum(int[] arr, int number)
{
    string number_1 = "Нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (number == arr[i]) { number_1 = "Да"; break; }
        // else Console.WriteLine($"{number_1}, {arr[i]} -> нет");
    }
    Console.WriteLine($"{number}, {number_1} ");
}

int[] arr_1 = MassNums(10);
Print(arr_1);
SomeNum(arr_1, 8);
