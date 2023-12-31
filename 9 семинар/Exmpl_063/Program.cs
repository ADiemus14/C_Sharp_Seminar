﻿/* Задача 63: 
Задайте значение N. 
Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"

N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{PrintNumbers(1, N)}");

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    
    return (start +", "+ PrintNumbers(start + 1, end));
}