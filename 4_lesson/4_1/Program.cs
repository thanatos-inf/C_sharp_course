// Напишите программу, которая принимает на вход число (А) и выдаёт сумму числе от 1 до А. 


int SumNum(int num)
{
    int all_sum = 0;
    for(int i = 1; i <= num; i++) all_sum +=i;

    return all_sum;

}

Console.WriteLine(SumNum(7));
Console.WriteLine(SumNum(4));
