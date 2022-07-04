//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную
//степень B.

int PowNum(int num1, int num2)
{
    int i = 2;
    int result = num1;
    while (i <= num2)
    {
        result = result * num1;
        i++;
    }
    return result;
}

int res = PowNum(3, 5);
Console.WriteLine(res);

// Или так:
// int PowNum(int num1, int num2)
// {
//     int result = num1;
//     for (int i = 2; i <= num2; i++) result *= num1;

//     return result;
// }

// int res = PowNum(2, 4);
// Console.WriteLine(res);