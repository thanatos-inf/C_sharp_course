﻿//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и
//единицами в случайном порядке.

void Array()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] =new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}

Array();