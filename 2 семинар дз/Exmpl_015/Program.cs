// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите день недели, где 1 - Понедельник, а 7 - Воскресенье: ");
int Date = (Console.ReadLine ()!);

if (Date = 6 || Date = 7 ){
    Console.WriteLine ("Данный день недели является выходным");
}

else Console.WriteLine ("Это будний день недели");