/* Задача 54: Задайте двумерный массив.
Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

SortingMaxMin(array);
PrintArray(array);

//получение массива 2мер

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

//Вывод массива

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

//сортировка от макс к мин

void SortingMaxMin(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
{
    if (array[i, k] < array[i, k + 1])
    {
        int variable = array[i, k + 1];
        array[i, k + 1] = array[i, k];
        array[i, k] = variable;
    }
}
}
}
}









// // метод заменыы последней строки на первую
// void ChangeRow(int[,] inArray)
// {
//     for (int j = 0; j < inArray.GetLength(1); j++)
//     {
//         int temp = inArray[0, j];
//         inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
//         inArray[inArray.GetLength(0) - 1, j] = temp;
//     }
//     PrintArray(inArray);
// }