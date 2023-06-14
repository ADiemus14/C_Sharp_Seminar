Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int sqr = a * a;
Console.WriteLine($"Квадрат данного числа равен = {sqr} (Математически)");

int sqr1 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine($"Квадрат данного числа, равен = {sqr1} (Библиотека...)");