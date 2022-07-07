// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int NumSum(int num)
{
    int fig_sum = 0;
    while(num > 0)
    {
        fig_sum = fig_sum + num % 10;
        num /=10;
    }
    return fig_sum;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Сумма цифр введённого Вами числа равна: ");
Console.Write(NumSum(num));