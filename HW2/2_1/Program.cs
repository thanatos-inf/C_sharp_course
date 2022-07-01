//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.


int SecondNum(int num)
{
    return (num % 100) / 10;
}

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Вторая цифра введённого числа: ");
Console.Write(SecondNum(num));
