//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно
//палиндромом.

void Palindrome(int num)
{
    if (((num % 100000) / 10000 == (num % 10)) & ((num % 10000) / 1000 == (num % 100) / 10)) Console.WriteLine("Да! Введённое Вами число - это палиндром.");
    else Console.WriteLine("Нет! Это не палиндром!");
}

Palindrome(68786);
Palindrome(65432);
Palindrome(12321);

//void Quarters(int Number)
//{
//    if (Number == 1) Console.WriteLine("x > 0 & y > 0");
//    else if (Number == 2) Console.WriteLine("x < 0 & y > 0");
//    else if (Number == 3) Console.WriteLine("x < 0 & y < 0");
//    else if (Number == 4) Console.WriteLine("x > 0 & y < 0");
//    else Console.WriteLine("не верно");
//}

//Quarters(1);
//Quarters(4);

//(num % 100) / 10; - четвертая
//(num % 10); - пятая
//(num % 10000) / 1000; - вторая
//(num % 100000) / 10000 - первая