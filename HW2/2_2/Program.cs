//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру
//этого числа.

int SecondNum(int num)
{
    return (num / 100) * 10 + (num % 10);
}

int num = new Random().Next(100, 1000);
Console.Write("Вводное трёхзначное число: ");
Console.WriteLine(num);

Console.Write("Результат: ");
Console.Write(SecondNum(num));
