// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

void OneOfNum(int num)
{       
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");       
    }    
}

OneOfNum(15);
OneOfNum(161);