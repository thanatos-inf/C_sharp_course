//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int Holiday(int num)
{       
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Да, выходной!");
    }
    else
    {
        Console.WriteLine("Нет, иди работай!");       
    } 
    return num;   
}

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//Console.Write(Holiday(num));

Holiday(6);
Holiday(5);
Holiday(1);
Holiday(7);