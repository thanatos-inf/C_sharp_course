// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.

string EvenString (int M, int N)
{
    if (M % 2 != 0) M = M + 1;
    if (M <= N) return $"{M} " + EvenString(M + 2, N);
    else return String.Empty;
}

Console.WriteLine(EvenString(1, 5));
Console.WriteLine(EvenString(4, 8));