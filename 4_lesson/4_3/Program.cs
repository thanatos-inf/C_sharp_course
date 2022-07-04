// Напишите программу, которая принимает на вход число (N) и выдаёт произведение чисел от 1 до N. 


int MultNum(int num)
{
    int all_sum = 1;
    for(int i = 1; i <= num; i++) all_sum *=i;

    return all_sum;

}

Console.WriteLine(MultNum(5));

