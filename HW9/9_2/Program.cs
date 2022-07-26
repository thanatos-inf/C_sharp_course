//  Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.


int ElSum(int M, int N)
{
    if (N < M) return 0;
    return ElSum(M, N-1) + N;
}

Console.WriteLine(ElSum(1, 15));
Console.WriteLine(ElSum(4, 8));

