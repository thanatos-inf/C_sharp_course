// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int ThirdNum(int num)
{
    if(num >= 100 & num < 1000)
    {
    return(num % 10);
    }

    while(num > 999) num = num / 10;
    return(num % 10);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return;
    }
else
Console.Write("Третья цифра введённого числа: ");
Console.Write(ThirdNum(num));
