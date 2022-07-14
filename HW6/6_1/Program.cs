// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPos (int num)
{
    int count = 0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число № {i}: ");
        int a = int.Parse(Console.ReadLine());
        if( a > 0 ) count++; 
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше нуля: {CountPos(a)}");