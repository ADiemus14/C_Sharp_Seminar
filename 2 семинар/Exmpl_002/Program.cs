﻿/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46

782 -> 72

918 -> 98*/

int r = new Random().Next(100, 1000);

int a = r/100;
int b = r % 10;

int x = a *10 + b;

Console.WriteLine($"Первая и третья цифры числа {r} = {x}");