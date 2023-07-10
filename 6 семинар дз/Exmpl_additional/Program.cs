/* Доп.Задача 
Не используя рекурсию,
выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1. 
(Следующее число складывается из двух предыдущих)

Если N = 5 -> 0 1 1 2 3

Если N = 3 -> 0 1 1

Если N = 7 -> 0 1 1 2 3 5 8 */

// f(1) = 1;
// f(2) = 1;
// f(n) = f(n-1) + f(n-2);

Console.Write("Задайте число: ");
int N = int.Parse(Console.ReadLine()!);

int n1 = 1;
Console.Write($"{n1}, ");
int n2 = 1;
Console.Write($"{n2}, ");
int sum = 0;

while (N >= sum){
    sum = n1 + n2;
    Console.Write($"{sum}, ");
    n1 = n2;
    n2 = sum;
}
// Console.Write($"{n1} , {String.Join(", " , sum) }");