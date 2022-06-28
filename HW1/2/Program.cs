Console.WriteLine("Введите три числа: ");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numC = int.Parse(Console.ReadLine());
int max = numA;
if(numB > max) max = numB;
if(numC > max) max = numC;

Console.Write("Максимальное число: ");
Console.Write(max);