/* Задача 50. 
Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует */

// Метод заполнения двумерного массива  
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод вывода двумерного массива 
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// метод вывода элемента
void PrintEl(int rowNum, int columnsNum, int[,] Array)
{
    if (rowNum < Array.GetLength(0) && columnsNum < Array.GetLength(1))
    {
        Console.WriteLine($"{Array[rowNum, columnsNum]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента не существует");
    }

}

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);

int[,] newArray = GetArray(m, n, 1, 10);
PrintArray(newArray);


Console.Write("Введите номер строки: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine()!);

PrintEl(rows, columns, newArray);