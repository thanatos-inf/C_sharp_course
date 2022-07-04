Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
if(numA < numB)
{
    Console.Write("Максимальное число: ");
    Console.Write(numB);
}
else
{
    Console.Write("Максимальное число: ");
    Console.Write(numA);
}