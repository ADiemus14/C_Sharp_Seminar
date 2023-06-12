// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число: {a} ");
}

if (b > a && b > c)
{
    Console.WriteLine($"Максимальное число: {b} ");
}
if (c > a && c > b)
{
    Console.WriteLine($"Максимальное число: {c} ");
}