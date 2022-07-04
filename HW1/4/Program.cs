Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 2;
Console.WriteLine("Ряд чисел: ");
while (M < N + 1)
{
    Console.WriteLine(M);
    M += 2;
}