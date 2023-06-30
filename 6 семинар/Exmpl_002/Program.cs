/**Задача 40:** Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.

<aside>
❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

</aside> */

Console.Write("Задайте размер первой сторны треугольника: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Задайте размер второй сторны треугольника: ");
int B = int.Parse(Console.ReadLine()!);

Console.Write("Задайте размер третей сторны треугольника: ");
int C = int.Parse(Console.ReadLine()!);

if(GetTriangle(A, B, C)) Console.Write($"Треугольник с длинами {A} {B} {C} существует");
else Console.Write($"Треугольник с длинами {A} {B} {C} не существует");

//Метод сравнения сторон
bool GetTriangle(int A, int B, int C){
    if((A < B+C) && (B < A+C) && (C < B+A)) return true;
    else return false;
}