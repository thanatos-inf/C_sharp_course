Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine());
int result = N;

if (N < 0)
{
    result = -N;
}

Console.Write("Модуль введённого Вами числа равен: ");
Console.WriteLine(result);